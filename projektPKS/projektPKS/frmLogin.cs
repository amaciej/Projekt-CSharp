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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True";

        private void but_login_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(conString);
            string q1 = "Select * from UŻYTKOWNICY where Id_Upr = 1 and Login = '" + txt_Login.Text.Trim() + "' and Hasło = '" + txt_Hasło.Text.Trim() + "'";
            SqlDataAdapter sda1 = new SqlDataAdapter(q1, sqlcon);
            string q2 = "Select * from UŻYTKOWNICY where Id_Upr = 2 and Login = '" + txt_Login.Text.Trim() + "' and Hasło = '" + txt_Hasło.Text.Trim() + "'";
            SqlDataAdapter sda2 = new SqlDataAdapter(q2, sqlcon);
            string q3 = "Select * from UŻYTKOWNICY where Id_Upr = 3 and Login = '" + txt_Login.Text.Trim() + "' and Hasło = '" + txt_Hasło.Text.Trim() + "'";
            SqlDataAdapter sda3 = new SqlDataAdapter(q3, sqlcon);
            string q4 = "Select * from UŻYTKOWNICY where Id_Upr = 4 and Login = '" + txt_Login.Text.Trim() + "' and Hasło = '" + txt_Hasło.Text.Trim() + "'";
            SqlDataAdapter sda4 = new SqlDataAdapter(q4, sqlcon);
            DataTable dtbl = new DataTable();
            DataTable dtb2 = new DataTable();
            DataTable dtb3 = new DataTable();
            DataTable dtb4 = new DataTable();
            sda1.Fill(dtbl);
            sda2.Fill(dtb2);
            sda3.Fill(dtb3);
            sda4.Fill(dtb4);
            if (dtbl.Rows.Count == 1)
            {
                Administrator oAdmin = new Administrator();
                this.Hide();
                oAdmin.Show();

            }
            else if (dtb2.Rows.Count == 1)
            {
                frmDyspozytor oDysp = new frmDyspozytor();
                this.Hide();
                oDysp.Show();

            }
            else if (dtb3.Rows.Count == 1)
            {
                frmKierowca oKier = new frmKierowca();
                this.Hide();
                oKier.Show();

            }
            else if (dtb4.Rows.Count == 1)
            {
                frmPasażer oPas = new frmPasażer();
                this.Hide();
                oPas.Show();

            }
            else
            {
                MessageBox.Show("Login lub hasło jest niepoprawne", "Błąd", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void but_haslo_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRejestracja oRej = new frmRejestracja();
            oRej.Show();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Czy chcesz zamknąć aplikację ?", "Zamknij",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if(dg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
