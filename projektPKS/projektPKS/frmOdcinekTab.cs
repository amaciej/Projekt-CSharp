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
    public partial class frmOdcinekTab : Form
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");
        int Id_Odcinek = 0;
        int p = 0;
        int k = 0;
        public frmOdcinekTab()
        {
            InitializeComponent();
        }

        public void ComboBoxPoczątek()
        {
            sqlcon.Open();
            string query = "select Id_Miejscowości, M_Nazwa from MIEJSCOWOŚCI";
            SqlCommand sc = new SqlCommand(query, sqlcon);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Id_Miejscowości", typeof(string));
            dt.Columns.Add("M_Nazwa", typeof(string));
            dt.Load(reader);

            cb_poczatek.ValueMember = "Id_Miejscowości";
            cb_poczatek.DisplayMember = "M_Nazwa";
            cb_poczatek.DataSource = dt;
            sqlcon.Close();
        }

        public void ComboBoxKoniec()
        {
            sqlcon.Open();
            string query = "select Id_Miejscowości, M_Nazwa from MIEJSCOWOŚCI";
            SqlCommand sc = new SqlCommand(query, sqlcon);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Id_Miejscowości", typeof(string));
            dt.Columns.Add("M_Nazwa", typeof(string));
            dt.Load(reader);

            cb_koniec.ValueMember = "Id_Miejscowości";
            cb_koniec.DisplayMember = "M_Nazwa";
            cb_koniec.DataSource = dt;
            sqlcon.Close();
        }

        void WyswietlDane()
        {
            string query = "select od.Id_Odcinek, mS.M_Nazwa as Miejscowość_S, mK.M_Nazwa as Miejscowości_K,od.Długość, od.Godz_Początek, od.Godz_Koniec,od.Cena_Biletu from ODCINEK od inner join MIEJSCOWOŚCI mS on od.Id_Miejscowości_S = mS.Id_Miejscowości inner join MIEJSCOWOŚCI mK on od.Id_Miejscowości_K = mK.Id_Miejscowości; ";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvOdcinek.DataSource = dt.DefaultView;
        }
        void Clear()
        {
            txt_cena.Text = txt_Dlugosc.Text = txt_gkoniec.Text = txt_gPoczatek.Text = txt_IdOdcinek.Text = txt_szukaj.Text = "";
            Id_Odcinek = 0;
            cb_koniec.Text = "";
            cb_poczatek.Text = "";
            but_save.Text = "Zapisz";
            but_usun.Enabled = false;
            p = 0;
            k = 0;
        }

        class ODCINEK
        {
            public int Id_Odcinek { get; set; }
            public int Id_Miejscowości_S { get; set; }
            public int Id_Miejscowości_K { get; set; }
            public string Długość{ get; set; }
            public object Godz_Początek { get; set; }
            public object Godz_Koniec { get; set; }
            public float Cena_Biletu { get; set; }

        }

        private void but_save_Click(object sender, EventArgs e)
        {
            try
            {
                p = cb_poczatek.SelectedIndex + 1;
                k = cb_koniec.SelectedIndex + 1;
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id_Odcinek", Id_Odcinek);
                param.Add("@Id_Miejscowosci_S", p);
                param.Add("@Id_Miejscowosci_K", k);
                param.Add("@Dlugosc", txt_Dlugosc.Text.Trim());
                param.Add("@Godz_Poczatek", txt_gPoczatek.Text.Trim());
                param.Add("@Godz_Koniec", txt_gkoniec.Text.Trim());
                param.Add("@Cena_Biletu", txt_cena.Text.Trim());

                sqlcon.Execute("Odcinek_AddorEdit", param, commandType: CommandType.StoredProcedure);
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

        private void frmOdcinekTab_Load(object sender, EventArgs e)
        {
            try
            {
                ComboBoxKoniec();
                ComboBoxPoczątek();
                WyswietlDane();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void but_szukaj_Click(object sender, EventArgs e)
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

        private void dgvOdcinek_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvOdcinek.CurrentRow.Index != -1)
                {
                    Id_Odcinek = Convert.ToInt32(dgvOdcinek.CurrentRow.Cells[0].Value.ToString());
                    txt_IdOdcinek.Text = dgvOdcinek.CurrentRow.Cells[0].Value.ToString();
                    cb_poczatek.Text = dgvOdcinek.CurrentRow.Cells[1].Value.ToString();
                    cb_koniec.Text = dgvOdcinek.CurrentRow.Cells[2].Value.ToString();
                    txt_Dlugosc.Text = dgvOdcinek.CurrentRow.Cells[3].Value.ToString();
                    txt_gPoczatek.Text = dgvOdcinek.CurrentRow.Cells[4].Value.ToString();
                    txt_gkoniec.Text = dgvOdcinek.CurrentRow.Cells[5].Value.ToString();
                    txt_cena.Text = dgvOdcinek.CurrentRow.Cells[6].Value.ToString();
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
                param.Add("@Id_Odcinek", Id_Odcinek);
                sqlcon.Execute("OdcinekDeleteById", param, commandType: CommandType.StoredProcedure);
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
