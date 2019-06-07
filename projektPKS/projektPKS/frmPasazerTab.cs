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
    public partial class frmPasazerTab : Form
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");
        int Id_Pasazer = 0;
        public frmPasazerTab()
        {
            InitializeComponent();
        }

        void WyswietlDane()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@szukajText", txt_szukaj.Text.Trim());

            List<PASAŻEROWIE> list = sqlcon.Query<PASAŻEROWIE>("Pasazerowie_ViewAllorSearch", param, commandType: CommandType.StoredProcedure).ToList<PASAŻEROWIE>();

            dgvPas.DataSource = list;
        }
        void Clear()
        {
            txt_IdPas.Text = txt_Imie.Text = txt_Nazw.Text = txt_szukaj.Text = "";
            Id_Pasazer = 0;
            but_save.Text = "Zapisz";
            but_usun.Enabled = false;
        }

        class PASAŻEROWIE
        {
            public int Id_Pasażer { get; set; }
            public string Imię { get; set; }
            public string Nazwisko { get; set; }
        }

        private void but_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id_Pasazer", Id_Pasazer);
                param.Add("@Imie", txt_Imie.Text.Trim());
                param.Add("@Nazwisko", txt_Nazw.Text.Trim());

                sqlcon.Execute("Pasazerowie_AddorEdit", param, commandType: CommandType.StoredProcedure);
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

        private void frmPasazerTab_Load(object sender, EventArgs e)
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

        private void but_clear_Click(object sender, EventArgs e)
        {
            Clear();
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

        private void dgvPas_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvPas.CurrentRow.Index != -1)
                {
                    Id_Pasazer = Convert.ToInt32(dgvPas.CurrentRow.Cells[0].Value.ToString());
                    txt_IdPas.Text = dgvPas.CurrentRow.Cells[0].Value.ToString();
                    txt_Imie.Text = dgvPas.CurrentRow.Cells[1].Value.ToString();
                    txt_Nazw.Text = dgvPas.CurrentRow.Cells[2].Value.ToString();
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
                param.Add("@Id_Pasazer", Id_Pasazer);
                sqlcon.Execute("Pasazerowie_DeleteById", param, commandType: CommandType.StoredProcedure);
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
