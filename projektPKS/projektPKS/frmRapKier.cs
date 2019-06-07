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

namespace projektPKS
{
    public partial class frmRapKier : Form
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");
        public frmRapKier()
        {
            InitializeComponent();
        }

        void PokazKurs()
        {
            try
            {
                string query = "select kier.PESEL as 'Twój PESEL', k.Id_Kursy, t.Nazwa as 'Nazwa Trasy', k.Dni, k.Godz_Początek, k.Godz_Koniec,a.Id_Autokaru, a.Marka, a.Model, a.Nr_Rejstracyjny from KURSY k inner join TRASY t on k.Id_Trasy = t.Id_Trasy inner join AUTOKARY a on k.Id_Autokaru = a.Id_Autokaru inner join KIEROWCY kier on a.Id_Kierowcy = kier.Id_Kierowcy where a.Id_Kierowcy = " + txt_IdKier.Text;
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgv_kier.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void but_Pokaz_Click(object sender, EventArgs e)
        {
            PokazKurs();
        }
    }
}
