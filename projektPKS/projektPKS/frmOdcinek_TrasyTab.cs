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
    public partial class frmOdcinek_TrasyTab : Form
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");
        int Id_Trasy = 0;
        int Id_Odcinek = 0;
        public frmOdcinek_TrasyTab()
        {
            InitializeComponent();
        }

        void WyswietlDane()
        {
            string query = "select t.Nazwa, odt.Id_Odcinek, odt.Kolejność from ODCINEK_TRASY odt inner join TRASY t on odt.Id_Trasy = t.Id_Trasy";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgv_OdcTras.DataSource = dt.DefaultView;
        }
        void Clear()
        {
            txt_IdOdcinek.Text = txt_IdTrasy.Text = txt_kolej.Text = txt_szukaj.Text = "";
            Id_Trasy = 0;
            Id_Odcinek = 0;
            but_save.Text = "Zapisz";
            but_usun.Enabled = false;
        }

        class ODCINEK_TRASY
        {
            public int Id_Trasy { get; set; }
            public int Id_Odcinek { get; set; }
            public int Kolejność { get; set; }
        }

        private void but_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id_Trsay", Id_Trasy);
                param.Add("@Id_Trsay", txt_IdTrasy.Text.Trim());
                param.Add("@Id_Odcinek", Id_Odcinek);
                param.Add("@Id_Odcinek", txt_IdOdcinek.Text.Trim());
                param.Add("@Kolejnosc", txt_kolej.Text.Trim());

                sqlcon.Execute("OdcinekTrasy_AddorEdit", param, commandType: CommandType.StoredProcedure);
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

        private void frmOdcinek_TrasyTab_Load(object sender, EventArgs e)
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

        private void dgv_OdcTras_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgv_OdcTras.CurrentRow.Index != -1)
                {
                    Id_Trasy = Convert.ToInt32(dgv_OdcTras.CurrentRow.Cells[0].Value.ToString());
                    Id_Odcinek = Convert.ToInt32(dgv_OdcTras.CurrentRow.Cells[1].Value.ToString());
                    txt_IdTrasy.Text = dgv_OdcTras.CurrentRow.Cells[0].Value.ToString();
                    txt_IdOdcinek.Text = dgv_OdcTras.CurrentRow.Cells[1].Value.ToString();
                    txt_kolej.Text = dgv_OdcTras.CurrentRow.Cells[2].Value.ToString();
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
                param.Add("@Id_Odcinek", Id_Odcinek);
                sqlcon.Execute("OdcinekTrasy_DeleteById", param, commandType: CommandType.StoredProcedure);
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
