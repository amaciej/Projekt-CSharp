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
    public partial class frmPasKursTab : Form
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");
        int Id_PasKurs = 0;
        public frmPasKursTab()
        {
            InitializeComponent();
        }

        void WyswietlDane()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@szukajText", txt_szukaj.Text.Trim());

            List<PASAŻEROWIE_KURSY> list = sqlcon.Query<PASAŻEROWIE_KURSY>("PasazerowieKursy_ViewAllorSearch", param, commandType: CommandType.StoredProcedure).ToList<PASAŻEROWIE_KURSY>();

            dgvPasKurs.DataSource = list;
        }
        void Clear()
        {
            txt_IdKurs.Text = txt_IdPas.Text = txt_IdPasKurs.Text = txt_szukaj.Text = "";
            Id_PasKurs = 0;
            but_save.Text = "Zapisz";
            but_usun.Enabled = false;
        }

        class PASAŻEROWIE_KURSY
        {
            public int Id_PasKurs { get; set; }
            public int Id_Kursy { get; set; }
            public int Id_Pasażer { get; set; }
        }

        private void but_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id_PasKurs", Id_PasKurs);
                param.Add("@Id_Kursy", txt_IdKurs.Text.Trim());
                param.Add("@Id_Pasazer", txt_IdPas.Text.Trim());

                sqlcon.Execute("PasazerowieKursy_AddorEdit", param, commandType: CommandType.StoredProcedure);
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

        private void frmPasKursTab_Load(object sender, EventArgs e)
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

        private void dgvPasKurs_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvPasKurs.CurrentRow.Index != -1)
                {
                    Id_PasKurs = Convert.ToInt32(dgvPasKurs.CurrentRow.Cells[0].Value.ToString());
                    txt_IdPasKurs.Text = dgvPasKurs.CurrentRow.Cells[0].Value.ToString();
                    txt_IdKurs.Text = dgvPasKurs.CurrentRow.Cells[1].Value.ToString();
                    txt_IdPas.Text = dgvPasKurs.CurrentRow.Cells[2].Value.ToString();
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
                param.Add("@Id_PasKurs", Id_PasKurs);
                sqlcon.Execute("PasazerowieKursy_DeleteById", param, commandType: CommandType.StoredProcedure);
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
