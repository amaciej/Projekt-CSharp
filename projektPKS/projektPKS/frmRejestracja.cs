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
    public partial class frmRejestracja : Form
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");
        int Id_Uzyt = 0;
        int upr = 0;
        public frmRejestracja()
        {
            InitializeComponent();
        }

        class UŻYTKOWNICY
        {
            public int Id_Użyt { get; set; }
            public int Id_Upr { get; set; }
            public string Login { get; set; }
            public string Hasło { get; set; }
        }

        void Dodaj()
        {
            if(rB_Admin.Checked == true)
            {
                upr = 1;
            }
            else if (rB_Dyspozytor.Checked == true)
            {
                upr = 2;
            }
            else if (rB_kierowca.Checked == true)
            {
                upr = 3;
            }
            else if (rB_Pasazer.Checked == true)
            {
                upr = 4;
            }
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id_Uzyt", Id_Uzyt);
                param.Add("@Id_Upr", upr);
                param.Add("@Login", txt_login.Text.Trim());
                param.Add("@Haslo", txt_haslo.Text.Trim());

                sqlcon.Execute("Uzytkownicy_AddorEdit", param, commandType: CommandType.StoredProcedure);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_haslo.Text =="" || txt_login.Text == "" ||( rB_Pasazer.Checked == false 
                                                            && rB_kierowca.Checked == false
                                                           && rB_Dyspozytor.Checked == false
                                                           && rB_Admin.Checked == false))
            {
                MessageBox.Show("Czegoś nie uzupełniłęś", "Błąd",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Dodaj();
                MessageBox.Show("Założyłeś konto", "Brawo !!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmLogin oLogin = new frmLogin();
                oLogin.Show();
            }
        }

        private void tb_close_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Czy chcesz zamknąć aplikację ?", "Zamknij",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tb_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin oLog = new frmLogin();
            oLog.Show();
        }

        private void frmRejestracja_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Czy chcesz zamknąć aplikację ?", "Zamknij",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
    
}
