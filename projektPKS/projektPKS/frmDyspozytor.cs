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
    public partial class frmDyspozytor : Form
    {
        public frmDyspozytor()
        {
            InitializeComponent();
        }

        private void but_Miejsc_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmMiejscowosciTab oMiasto = new frmMiejscowosciTab();
            oMiasto.TopLevel = false;
            panel.Controls.Add(oMiasto);
            oMiasto.Show();
        }

        private void but_odcinek_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmOdcinekTab oOdcinek = new frmOdcinekTab();
            oOdcinek.TopLevel = false;
            panel.Controls.Add(oOdcinek);
            oOdcinek.Show();
        }

        private void but_odcTras_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmOdcinek_TrasyTab oOdcTra = new frmOdcinek_TrasyTab();
            oOdcTra.TopLevel = false;
            panel.Controls.Add(oOdcTra);
            oOdcTra.Show();
        }

        private void but_trasy_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmTrasyTab oTrasy = new frmTrasyTab();
            oTrasy.TopLevel = false;
            panel.Controls.Add(oTrasy);
            oTrasy.Show();
        }

        private void but_kursy_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmKursyTab oKursy = new frmKursyTab();
            oKursy.TopLevel = false;
            panel.Controls.Add(oKursy);
            oKursy.Show();
        }

        private void but_HarmRuch_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmHarmoRuchu oHR = new frmHarmoRuchu();
            oHR.TopLevel = false;
            panel.Controls.Add(oHR);
            oHR.Show();
        }

        private void but_KierTras_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmRapKierTrasa oRKT = new frmRapKierTrasa();
            oRKT.TopLevel = false;
            panel.Controls.Add(oRKT);
            oRKT.Show();
        }

        private void but_IloPas_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmRapIloPas oIloPas = new frmRapIloPas();
            oIloPas.TopLevel = false;
            panel.Controls.Add(oIloPas);
            oIloPas.Show();
        }

        private void tBzamknij_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Czy chcesz zamknąć aplikację ?", "Zamknij",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tBWyloguj_Click(object sender, EventArgs e)
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

        private void tsb_ilPas_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmRapIloPas oIloPas = new frmRapIloPas();
            oIloPas.TopLevel = false;
            panel.Controls.Add(oIloPas);
            oIloPas.Show();
        }

        private void tsb_kier_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmRapKierTrasa oRKT = new frmRapKierTrasa();
            oRKT.TopLevel = false;
            panel.Controls.Add(oRKT);
            oRKT.Show();
        }

        private void tsb_harm_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmHarmoRuchu oHR = new frmHarmoRuchu();
            oHR.TopLevel = false;
            panel.Controls.Add(oHR);
            oHR.Show();
        }

        private void miejscowościToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmMiejscowosciTab oMiasto = new frmMiejscowosciTab();
            oMiasto.TopLevel = false;
            panel.Controls.Add(oMiasto);
            oMiasto.Show();
        }

        private void odcinekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmOdcinekTab oOdcinek = new frmOdcinekTab();
            oOdcinek.TopLevel = false;
            panel.Controls.Add(oOdcinek);
            oOdcinek.Show();
        }

        private void odcinkiWTrasachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmOdcinek_TrasyTab oOdcTra = new frmOdcinek_TrasyTab();
            oOdcTra.TopLevel = false;
            panel.Controls.Add(oOdcTra);
            oOdcTra.Show();
        }

        private void trasyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmTrasyTab oTrasy = new frmTrasyTab();
            oTrasy.TopLevel = false;
            panel.Controls.Add(oTrasy);
            oTrasy.Show();
        }

        private void kursyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmKursyTab oKursy = new frmKursyTab();
            oKursy.TopLevel = false;
            panel.Controls.Add(oKursy);
            oKursy.Show();
        }

        private void frmDyspozytor_FormClosing(object sender, FormClosingEventArgs e)
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
