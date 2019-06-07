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
    public partial class frmHarmoRuchu : Form
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");
        
        public frmHarmoRuchu()
        {
            InitializeComponent();
        }

        void WyswietlKursy()
        {
            string query = "select k.Id_Kursy, t.Nazwa as 'Nazwa Trasa', k.Id_Autokaru, k.Dni, k.Godz_Początek, k.Godz_Koniec, k.Ilość_Pasażerów from KURSY k inner join TRASY t on k.Id_Trasy = t.Id_Trasy";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvKursy.DataSource = dt.DefaultView;
        }

        void WyswietlHarm()
        {
            //@Id_Kursy = txt_IdKursy.Text;
            string query = "select mS.M_Nazwa as Miejscowość_S, mK.M_Nazwa as Miejscowości_K, od.Godz_Początek, od.Godz_Koniec, a.Id_Autokaru from ODCINEK od join MIEJSCOWOŚCI mS on od.Id_Miejscowości_S = mS.Id_Miejscowości join MIEJSCOWOŚCI  mK on od.Id_Miejscowości_K = mK.Id_Miejscowości join ODCINEK_TRASY odt on od.Id_Odcinek = odt.Id_Odcinek join KURSY k on odt.Id_Trasy = k.Id_Trasy join AUTOKARY a on k.Id_Autokaru = a.Id_Autokaru where k.Id_Kursy = " + txt_IdKursy.Text;
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            //cmd.Parameters.Add("@Td_Kursy", SqlDbType.VarChar).Value = Id_Kursy;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvHarmTrasy.DataSource = dt.DefaultView;

        }

        private void but_Pokaz_Click(object sender, EventArgs e)
        {
            try
            {
                //WyswietlDane();
                WyswietlHarm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmHarmoRuchu_Load(object sender, EventArgs e)
        {
            try
            {
                WyswietlKursy();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
