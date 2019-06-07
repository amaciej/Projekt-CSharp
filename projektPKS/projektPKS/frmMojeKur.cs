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
    public partial class frmMojeKur : Form
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");
        public frmMojeKur()
        {
            InitializeComponent();
        }

        void PokazKurs()
        {
            try
            {
                string query = "select t.Nazwa, k.Godz_Początek, k.Godz_Koniec, a.Id_Autokaru, a.Marka, a.Model from KURSY k inner join TRASY t on k.Id_Trasy = t.Id_Trasy inner join AUTOKARY a on k.Id_Autokaru = a.Id_Autokaru inner join PASAŻEROWIE_KURSY pk on k.Id_Kursy = pk.Id_Kursy inner join PASAŻEROWIE p on pk.Id_Pasażer = p.Id_Pasażer where p.Imię = @Imie and p.Nazwisko = @Nazwisko";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.Add("@Imie", SqlDbType.VarChar).Value = txt_imie.Text;
                cmd.Parameters.Add("@Nazwisko", SqlDbType.VarChar).Value = txt_nazw.Text;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dgvInfo.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void but_wys_Click(object sender, EventArgs e)
        {
            PokazKurs();
        }
    }
}
