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
    public partial class frmRapIloPas : Form
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");
        public frmRapIloPas()
        {
            InitializeComponent();
        }
        class PASAŻEROWIE_KURSY
        {
            public int Id_PasKurs { get; set; }
            public int Id_Kursy { get; set; }
            public int Id_Pasażer { get; set; }
        }

        void WyswitlRap()
        {
            try
            {
                string dataP = txt_godzS.Text;
                DateTime dP = DateTime.ParseExact(dataP, "yyyy-MM-dd HH:mm:ss",
                                       System.Globalization.CultureInfo.InvariantCulture);
                string dataK = txt_godzK.Text;
                DateTime dK = DateTime.ParseExact(dataK, "yyyy-MM-dd HH:mm:ss",
                                       System.Globalization.CultureInfo.InvariantCulture);
                string query = "select count(PASAŻEROWIE_KURSY.Id_Pasażer) as 'Ilość Pasażerów' from PASAŻEROWIE_KURSY inner join KURSY on PASAŻEROWIE_KURSY.Id_Kursy = KURSY.Id_Kursy where PASAŻEROWIE_KURSY.Id_Kursy = "+ txt_idKursu.Text +" and KURSY.Godz_Początek between @godzP and @godzK";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.Add("@godzP", SqlDbType.DateTime2).Value = dP;
                cmd.Parameters.Add("@godzK", SqlDbType.DateTime2).Value = dK;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgvRapIloPas.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void but_Pokaz_Click(object sender, EventArgs e)
        {
            WyswitlRap();
        }
        
    }
}
