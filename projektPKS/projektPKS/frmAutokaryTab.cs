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
    public partial class frmAutokaryTab : Form
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");
        int Id_Autokaru = 0;
        public frmAutokaryTab()
        {
            InitializeComponent();
        }

        void WyswietlDane()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@szukajText", txt_szukaj.Text.Trim());

            List<AUTOKARY> list = sqlcon.Query<AUTOKARY>("Autokary_ViewAllorSearch", param, commandType: CommandType.StoredProcedure).ToList<AUTOKARY>();

            dgv_Auto.DataSource = list;
        }
        void Clear()
        {
            txt_IdAuto.Text = txt_IdKierowcy.Text = txt_IloMiej.Text = txt_Marka.Text = txt_Model.Text =
                txt_Rocznik.Text = txt_NrRejs.Text = txt_szukaj.Text = "";
           Id_Autokaru = 0;
            but_save.Text = "Zapisz";
            but_usun.Enabled = false;
        }

        class AUTOKARY
        {
            public int Id_Autokaru { get; set; }
            public int Id_Kierowcy { get; set; }
            public string Nr_Rejstracyjny { get; set; }
            public int Iilość_Miejsc { get; set; }
            public string Marka { get; set; }
            public string Model { get; set; }
            public string Rocznik { get; set; }
        }

        private void but_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id_Autokaru", Id_Autokaru);
                param.Add("@Id_Kierowcy", txt_IdKierowcy.Text.Trim());
                param.Add("@Nr_Rejstracyjny", txt_NrRejs.Text.Trim());
                param.Add("@Ilosc_Miejsc", txt_IloMiej.Text.Trim());
                param.Add("@Marka", txt_Marka.Text.Trim());
                param.Add("@Model", txt_Model.Text.Trim());
                param.Add("@Rocznik", txt_Rocznik.Text.Trim());

                sqlcon.Execute("Autokary_AddorEdit", param, commandType: CommandType.StoredProcedure);
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

        private void frmAutokaryTab_Load(object sender, EventArgs e)
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

        private void dgv_Auto_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Auto.CurrentRow.Index != -1)
                {
                    Id_Autokaru = Convert.ToInt32(dgv_Auto.CurrentRow.Cells[0].Value.ToString());
                    txt_IdAuto.Text = dgv_Auto.CurrentRow.Cells[0].Value.ToString();
                    txt_IdKierowcy.Text = dgv_Auto.CurrentRow.Cells[1].Value.ToString();
                    txt_NrRejs.Text = dgv_Auto.CurrentRow.Cells[2].Value.ToString();
                    txt_IloMiej.Text = dgv_Auto.CurrentRow.Cells[3].Value.ToString();
                    txt_Marka.Text = dgv_Auto.CurrentRow.Cells[4].Value.ToString();
                    txt_Model.Text = dgv_Auto.CurrentRow.Cells[5].Value.ToString();
                    txt_Rocznik.Text = dgv_Auto.CurrentRow.Cells[6].Value.ToString();
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
                param.Add("@Id_Autokaru", Id_Autokaru);
                sqlcon.Execute("AutokaryDeleteById", param, commandType: CommandType.StoredProcedure);
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
