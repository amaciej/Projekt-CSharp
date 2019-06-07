using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektPKS
{
    public partial class frmPolaczenia : Form
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");
        int p = 0;
        int k = 0;
        public frmPolaczenia()
        {
            InitializeComponent();
        }

        

        private void frmPolaczenia_Load(object sender, EventArgs e)
        {
            try
            {
                cb_koniec.Text = "";
                cb_poczatek.Text = "";
                ComboBoxPoczątek();
                ComboBoxKoniec();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        void SzukajPolacz()
        {
            try
            {
                p = cb_poczatek.SelectedIndex + 1;
                k = cb_koniec.SelectedIndex + 1;
                string query = "select distinct m.M_Nazwa, t.Nazwa, m.Id_Miejscowości from MIEJSCOWOŚCI m inner join ODCINEK od on m.Id_Miejscowości = od.Id_Miejscowości_S inner join ODCINEK odd on m.Id_Miejscowości = odd.Id_Miejscowości_K inner join ODCINEK_TRASY odt on od.Id_Odcinek = odt.Id_Odcinek inner join TRASY t on odt.Id_Trasy = t.Id_Trasy inner join KURSY k on odt.Id_Trasy = k.Id_Trasy where od.Id_Miejscowości_S = "+ p +" or od.Id_Miejscowości_K = "+k;
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgvPolacz.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void but_szukaj_Click(object sender, EventArgs e)
        {
            SzukajPolacz();
        }
    }
}
