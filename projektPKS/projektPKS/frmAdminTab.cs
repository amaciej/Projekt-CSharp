using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;

namespace projektPKS
{
    public partial class frmAdminTab : Form
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");
        int Id_Uzyt = 0;
        int index = 0;
        public frmAdminTab()
        {
            InitializeComponent();
        }

        void WyswietlDane()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@szukajText", txt_szukaj.Text.Trim());

            List<UŻYTKOWNICY> list = sqlcon.Query<UŻYTKOWNICY>("Uzytkownicy_ViewAllorSearch", param, commandType: CommandType.StoredProcedure).ToList<UŻYTKOWNICY>();

            dgvUzyt.DataSource = list;
        }
        void Clear()
        {
            txt_IdUpr.Text = txt_IdUzyt.Text = txt_login.Text = txt_Haslo.Text = txt_szukaj.Text = "";
            Id_Uzyt = 0;
            but_save.Text = "Zapisz";
            but_usun.Enabled = false;
        }

        class UŻYTKOWNICY
        {
            public int Id_Użyt { get; set; }
            public int Id_Upr { get; set; }
            public string Login { get; set; }
            public string Hasło { get; set; }
        }

        private void but_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id_Uzyt", Id_Uzyt);
                param.Add("@Id_Upr", txt_IdUpr.Text.Trim());
                param.Add("@Login", txt_login.Text.Trim());
                param.Add("@Haslo", txt_Haslo.Text.Trim());

                sqlcon.Execute("Uzytkownicy_AddorEdit", param, commandType: CommandType.StoredProcedure);
                WyswietlDane();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void frmAdminTab_Load(object sender, EventArgs e)
        {
            try
            {
                WyswietlDane();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void but_Szukaj_Click(object sender, EventArgs e)
        {
            try
            {
                WyswietlDane();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void but_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvUzyt_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvUzyt.CurrentRow.Index != -1)
                {
                    Id_Uzyt = Convert.ToInt32(dgvUzyt.CurrentRow.Cells[0].Value.ToString());
                    txt_IdUzyt.Text = dgvUzyt.CurrentRow.Cells[0].Value.ToString();
                    txt_IdUpr.Text = dgvUzyt.CurrentRow.Cells[1].Value.ToString();
                    txt_login.Text = dgvUzyt.CurrentRow.Cells[2].Value.ToString();
                    txt_Haslo.Text = dgvUzyt.CurrentRow.Cells[3].Value.ToString();
                    but_usun.Enabled = true;
                    but_save.Text = "Edytuj";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void but_usun_Click(object sender, EventArgs e)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id_Uzyt", Id_Uzyt);
                sqlcon.Execute("Uzytkownicy_DeleteById", param, commandType: CommandType.StoredProcedure);
                Clear();
                WyswietlDane();
                MessageBox.Show("Usunięto poprawnie");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
