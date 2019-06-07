using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektPKS
{
    public partial class frmPasażer : Form
    {
        public frmPasażer()
        {
            InitializeComponent();
        }

        private void tb_close_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Czy chcesz zamknąć aplikację ?", "Zamknij",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tb_logout_Click(object sender, EventArgs e)
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

        private void but_add_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmAddPass oAdd = new frmAddPass();
            oAdd.TopLevel = false;
            panel.Controls.Add(oAdd);
            oAdd.Show();
        }

        private void but_moje_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmMojeKur oMoje = new frmMojeKur();
            oMoje.TopLevel = false;
            panel.Controls.Add(oMoje);
            oMoje.Show();
        }

        private void but_Poł_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmPolaczenia oPolacz= new frmPolaczenia();
            oPolacz.TopLevel = false;
            panel.Controls.Add(oPolacz);
            oPolacz.Show();
        }

        private void tsB_add_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmAddPass oAdd = new frmAddPass();
            oAdd.TopLevel = false;
            panel.Controls.Add(oAdd);
            oAdd.Show();
        }

        private void tsb_mKurs_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmMojeKur oMoje = new frmMojeKur();
            oMoje.TopLevel = false;
            panel.Controls.Add(oMoje);
            oMoje.Show();
        }

        private void tsb_polacz_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmPolaczenia oPolacz = new frmPolaczenia();
            oPolacz.TopLevel = false;
            panel.Controls.Add(oPolacz);
            oPolacz.Show();
        }

        private void frmPasażer_FormClosing(object sender, FormClosingEventArgs e)
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

        private void but_harm_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmHarmoRuchu oHR = new frmHarmoRuchu();
            oHR.TopLevel = false;
            panel.Controls.Add(oHR);
            oHR.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmHarmoRuchu oHR = new frmHarmoRuchu();
            oHR.TopLevel = false;
            panel.Controls.Add(oHR);
            oHR.Show();
        }
    }
}
