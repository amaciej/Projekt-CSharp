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
    public partial class frmTrasyTab : Form
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");
        int Id_Trasy = 0;
        public frmTrasyTab()
        {
            InitializeComponent();
        }

        void WyswietlDane()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@szukajText", txt_szukaj.Text.Trim());

            List<TRASY> list = sqlcon.Query<TRASY>("Trasy_ViewAllorSearch", param, commandType: CommandType.StoredProcedure).ToList<TRASY>();

            dgvTrasy.DataSource = list;
        }
        void Clear()
        {
            txt_CzasTras.Text = txt_IdTrasy.Text = txt_Nazwa.Text = txt_szukaj.Text = "";
            Id_Trasy = 0;
            but_save.Text = "Zapisz";
            but_usun.Enabled = false;
        }

        class TRASY
        {
            public int Id_Trasy { get; set; }
            public string Nazwa { get; set; }
            public int Czas_Trasy { get; set; }
        }

        private void but_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id_Trsay", Id_Trasy);
                param.Add("@Nazwa", txt_Nazwa.Text.Trim());
                param.Add("@Czas_Trasy", txt_CzasTras.Text.Trim());

                sqlcon.Execute("Trasy_AddorEdit", param, commandType: CommandType.StoredProcedure);
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

        private void frmTrasyTab_Load(object sender, EventArgs e)
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

        private void dgvTrasy_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvTrasy.CurrentRow.Index != -1)
                {
                    Id_Trasy = Convert.ToInt32(dgvTrasy.CurrentRow.Cells[0].Value.ToString());
                    txt_IdTrasy.Text = dgvTrasy.CurrentRow.Cells[0].Value.ToString();
                    txt_Nazwa.Text = dgvTrasy.CurrentRow.Cells[1].Value.ToString();
                    txt_CzasTras.Text = dgvTrasy.CurrentRow.Cells[2].Value.ToString();
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
                param.Add("@Id_Trasy", Id_Trasy);
                sqlcon.Execute("Trasy_DeleteById", param, commandType: CommandType.StoredProcedure);
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
