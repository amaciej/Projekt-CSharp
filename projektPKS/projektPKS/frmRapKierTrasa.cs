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
using System.Globalization;

namespace projektPKS
{
    public partial class frmRapKierTrasa : Form
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");
        public frmRapKierTrasa()
        {
            InitializeComponent();
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

        class AUTOKARY
        {
            public int Id_Autokaru { get; set; }
            public int Id_Kierowcy { get; set; }
            public string Nr_Rejstracyjny { get; set; }
            public int Ilość_Miejsc { get; set; }
            public string Marka { get; set; }
            public string Model { get; set; }
            public string Rocznik { get; set; }
        }

        class KIEROWCY
        {
            public int Id_Kierowcy { get; set; }
            public string Imię { get; set; }
            public string Nazwisko { get; set; }
            public decimal PESEL { get; set; }
        }

        void WyswitlRap()
        {
            try
            {
                string time = txt_Time.Text;
                DateTime parseTime = DateTime.Parse(time);
                string t = parseTime.ToString("HH:mm:ss");
                string query = "select distinct KIEROWCY.Id_Kierowcy, KIEROWCY.Imię, KIEROWCY.Nazwisko  from KIEROWCY inner join AUTOKARY on KIEROWCY.Id_Kierowcy = AUTOKARY.Id_Kierowcy inner join KURSY on AUTOKARY.Id_Autokaru = KURSY.Id_Autokaru inner join ODCINEK_TRASY on KURSY.Id_Trasy = ODCINEK_TRASY.Id_Trasy inner join ODCINEK on ODCINEK_TRASY.Id_Odcinek = ODCINEK.Id_Odcinek where ODCINEK.Godz_Początek > @time order by KIEROWCY.Id_Kierowcy ";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.Add("@time", SqlDbType.Time).Value = t;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgvKierTrasa.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void but_pokaz_Click(object sender, EventArgs e)
        {
            WyswitlRap();
        }
    }
}
