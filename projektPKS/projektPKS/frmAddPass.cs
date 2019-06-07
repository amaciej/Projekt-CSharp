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
    public partial class frmAddPass : Form
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");
        public frmAddPass()
        {
            InitializeComponent();
        }

        void DodajPas()
        {
            try
            {
                string query = "Insert into PASAŻEROWIE (Imię, Nazwisko) values (@imie, @nazwisko)";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.Add("@imie", SqlDbType.Text).Value = txt_imie.Text;
                cmd.Parameters.Add("@nazwisko", SqlDbType.Text).Value = txt_nazw.Text;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                DialogResult dg = MessageBox.Show("Zapisano poprawinie", "Dodawanie",
                                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void but_Zapisz_Click(object sender, EventArgs e)
        {
            DodajPas();
        }
    }
}
