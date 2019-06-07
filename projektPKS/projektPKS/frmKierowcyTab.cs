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
    public partial class frmKierowcyTab : Form
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");
        int Id_Kierowcy = 0;
        public frmKierowcyTab()
        {
            InitializeComponent();
        }

        void WyswietlDane()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@szukajText", txt_szukaj.Text.Trim());

            List<KIEROWCY> list = sqlcon.Query<KIEROWCY>("Kierowcy_ViewAllorSearch", param, commandType: CommandType.StoredProcedure).ToList<KIEROWCY>();

            dgvKier.DataSource = list;
        }

        void Clear()
        {
            txt_IdKier.Text = txt_Imie.Text = txt_Nazw.Text = txt_pesel.Text = txt_szukaj.Text = "";
            Id_Kierowcy = 0;
            but_save.Text = "Zapisz";
            but_usun.Enabled = false;
        }

        class KIEROWCY
        {
            public int Id_Kierowcy { get; set; }
            public string Imię { get; set; }
            public string Nazwisko { get; set; }
            public decimal PESEL { get; set; }
        }

        private void but_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id_Kierowcy", Id_Kierowcy);
                param.Add("@Imię", txt_Imie.Text.Trim());
                param.Add("@Nazwisko", txt_Nazw.Text.Trim());
                param.Add("@PESEL", txt_pesel.Text.Trim());

                sqlcon.Execute("Kierowcy_AddorEditt", param, commandType: CommandType.StoredProcedure);
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

        private void frmKierowcyTab_Load(object sender, EventArgs e)
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

        private void dgvKier_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvKier.CurrentRow.Index != -1)
                {
                    Id_Kierowcy = Convert.ToInt32(dgvKier.CurrentRow.Cells[0].Value.ToString());
                    txt_IdKier.Text = dgvKier.CurrentRow.Cells[0].Value.ToString();
                    txt_Imie.Text = dgvKier.CurrentRow.Cells[1].Value.ToString();
                    txt_Nazw.Text = dgvKier.CurrentRow.Cells[2].Value.ToString();
                    txt_pesel.Text = dgvKier.CurrentRow.Cells[3].Value.ToString();
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
                param.Add("@Id_Kierowcy", Id_Kierowcy);
                sqlcon.Execute("KierowcyDeleteById", param, commandType: CommandType.StoredProcedure);
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
