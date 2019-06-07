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
    public partial class frmKursyTab : Form
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");
        int Id_Kursy = 0;
        int index = 0;
        public frmKursyTab()
        {
            InitializeComponent();
        }

        public void ComboBox()
        {
            sqlcon.Open();
            string query = "select Id_Trasy, Nazwa from TRASY";
            SqlCommand sc = new SqlCommand(query, sqlcon);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Id_Trasy", typeof(string));
            dt.Columns.Add("Nazwa", typeof(string));
            dt.Load(reader);

            cbTrasa.ValueMember = "Id_Trasy";
            cbTrasa.DisplayMember = "Nazwa";
            cbTrasa.DataSource = dt;
            sqlcon.Close();
        }

        void WyswietlDane()
        {
            string query = "select k.Id_Kursy, t.Nazwa as 'Nazwa Trasy', k.Id_Autokaru, k.Dni, k.Godz_Początek, k.Godz_Koniec, k.Ilość_Pasażerów from KURSY k inner join TRASY t on k.Id_Trasy = t.Id_Trasy";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvKursy.DataSource = dt.DefaultView;
        }
        void Clear()
        {
            txt_Dni.Text = txt_gKoniec.Text = txt_gPoczatek.Text = txt_IdAuto.Text = txt_IdKusry.Text = 
                txt_IloPas.Text = txt_szukaj.Text = "";
            cbTrasa.Text = "";
            Id_Kursy = 0;
            but_save.Text = "Zapisz";
            but_usun.Enabled = false;
        }

        class KURSY
        {
            public int Id_Kursy { get; set; }
            public int Id_Trasy { get; set; }
            public int Id_Autokaru { get; set; }
            public string Dni { get; set; }
            public object Godz_Początek { get; set; }
            public object Godz_Koniec { get; set; }
            public int Ilość_Pasażerów { get; set; }
        }

        private void but_save_Click(object sender, EventArgs e)
        {
            try
            {
                string dataP = txt_gPoczatek.Text;
                DateTime dP = DateTime.ParseExact(dataP, "yyyy-MM-dd HH:mm:ss",
                                       System.Globalization.CultureInfo.InvariantCulture);
                string dataK = txt_gKoniec.Text;
                DateTime dK = DateTime.ParseExact(dataK, "yyyy-MM-dd HH:mm:ss",
                                       System.Globalization.CultureInfo.InvariantCulture);
                //DateTime now1 = DateTime.Today;
                //cmd1.Parameters.AddWithValue("@Date", now1.ToShortDateString());
                index = cbTrasa.SelectedIndex +1;
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id_Kursy", Id_Kursy);
                param.Add("@Id_Trasy", index);
                param.Add("@Id_Autokaru", txt_IdAuto.Text.Trim());
                param.Add("@Dni", txt_Dni.Text.Trim());
                param.Add("@Godz_Poczatek", dP);
                param.Add("@Godz_Koniec", dK);
                param.Add("@Ilosc_Pasazerow", txt_IloPas.Text.Trim());

                sqlcon.Execute("Kursy_AddorEdit", param, commandType: CommandType.StoredProcedure);
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

        private void frmKursyTab_Load(object sender, EventArgs e)
        {
            try
            {
                ComboBox();
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

        private void dgvKursy_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvKursy.CurrentRow.Index != -1)
                {
                    Id_Kursy = Convert.ToInt32(dgvKursy.CurrentRow.Cells[0].Value.ToString());
                    txt_IdKusry.Text = dgvKursy.CurrentRow.Cells[0].Value.ToString();
                    cbTrasa.Text = dgvKursy.CurrentRow.Cells[1].Value.ToString();
                    txt_IdAuto.Text = dgvKursy.CurrentRow.Cells[2].Value.ToString();
                    txt_Dni.Text = dgvKursy.CurrentRow.Cells[3].Value.ToString();
                    txt_gPoczatek.Text = dgvKursy.CurrentRow.Cells[4].Value.ToString();
                    txt_gKoniec.Text = dgvKursy.CurrentRow.Cells[5].Value.ToString();
                    txt_IloPas.Text = dgvKursy.CurrentRow.Cells[6].Value.ToString();
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
                param.Add("@Id_Kursy", Id_Kursy);
                sqlcon.Execute("Kursy_DeleteById", param, commandType: CommandType.StoredProcedure);
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
