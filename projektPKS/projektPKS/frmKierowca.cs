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
    public partial class frmKierowca : Form
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");
        public frmKierowca()
        {
            InitializeComponent();
        }

        private void tb_zamknij_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Czy chcesz zamknąć aplikację ?", "Zamknij",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tB_wyloguj_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Czy chcesz się wylgować ?", "Wylogowywanie",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Hide();
                frmLogin login = new frmLogin();
                login.Show();
            }
        }


        private void but_Info_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmRapKier oRap = new frmRapKier();
            oRap.TopLevel = false;
            panel.Controls.Add(oRap);
            oRap.Show();
        }

        private void but_IloPas_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmRapIloPas oIloPas = new frmRapIloPas();
            oIloPas.TopLevel = false;
            panel.Controls.Add(oIloPas);
            oIloPas.Show();
        }

        private void tsb_info_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmRapKier oRap = new frmRapKier();
            oRap.TopLevel = false;
            panel.Controls.Add(oRap);
            oRap.Show();
        }

        private void tsb_ilosc_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmRapIloPas oIloPas = new frmRapIloPas();
            oIloPas.TopLevel = false;
            panel.Controls.Add(oIloPas);
            oIloPas.Show();
        }

        private void frmKierowca_FormClosing(object sender, FormClosingEventArgs e)
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
