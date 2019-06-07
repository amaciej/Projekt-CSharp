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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void tsbWyloguj_Click(object sender, EventArgs e)
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

        private void tsbZamknij_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Czy chcesz zamknąć aplikację ?", "Zamknij",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bMiasto_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmMiejscowosciTab oMiasto = new frmMiejscowosciTab();
            oMiasto.TopLevel = false;
            panel.Controls.Add(oMiasto);
            oMiasto.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmOdcinekTab oOdcinek = new frmOdcinekTab();
            oOdcinek.TopLevel = false;
            panel.Controls.Add(oOdcinek);
            oOdcinek.Show();
        }

        private void but_Trasy_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmTrasyTab oTrasy = new frmTrasyTab();
            oTrasy.TopLevel = false;
            panel.Controls.Add(oTrasy);
            oTrasy.Show();
        }

        private void but_OdcinekTrasa_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmOdcinek_TrasyTab oOdcTra = new frmOdcinek_TrasyTab();
            oOdcTra.TopLevel = false;
            panel.Controls.Add(oOdcTra);
            oOdcTra.Show();
        }

        private void but_Kursy_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmKursyTab oKursy = new frmKursyTab();
            oKursy.TopLevel = false;
            panel.Controls.Add(oKursy);
            oKursy.Show();
        }

        private void but_Autokary_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmAutokaryTab oAuto = new frmAutokaryTab();
            oAuto.TopLevel = false;
            panel.Controls.Add(oAuto);
            oAuto.Show();
        }

        private void but_Kierowcy_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmKierowcyTab oKier = new frmKierowcyTab();
            oKier.TopLevel = false;
            panel.Controls.Add(oKier);
            oKier.Show();
        }

        private void but_Pas_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmPasazerTab oPas = new frmPasazerTab();
            oPas.TopLevel = false;
            panel.Controls.Add(oPas);
            oPas.Show();
        }

        private void but_PasKurs_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmPasKursTab oPasKurs = new frmPasKursTab();
            oPasKurs.TopLevel = false;
            panel.Controls.Add(oPasKurs);
            oPasKurs.Show();
        }

        private void but_Uzyt_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmAdminTab oUzyt= new frmAdminTab();
            oUzyt.TopLevel = false;
            panel.Controls.Add(oUzyt);
            oUzyt.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmHarmoRuchu oHR = new frmHarmoRuchu();
            oHR.TopLevel = false;
            panel.Controls.Add(oHR);
            oHR.Show();
        }

        private void but_KierTrasa_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmRapKierTrasa oRKT = new frmRapKierTrasa();
            oRKT.TopLevel = false;
            panel.Controls.Add(oRKT);
            oRKT.Show();
        }

        private void but_IlPas_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmRapIloPas oIloPas = new frmRapIloPas();
            oIloPas.TopLevel = false;
            panel.Controls.Add(oIloPas);
            oIloPas.Show();
        }

        private void but_Pol_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmPolaczenia oPolacz = new frmPolaczenia();
            oPolacz.TopLevel = false;
            panel.Controls.Add(oPolacz);
            oPolacz.Show();
        }

        private void tsb_pol_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmPolaczenia oPolacz = new frmPolaczenia();
            oPolacz.TopLevel = false;
            panel.Controls.Add(oPolacz);
            oPolacz.Show();
        }

        private void tsb_iloPas_Click(object sender, EventArgs e)
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

        private void autokaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmAutokaryTab oAuto = new frmAutokaryTab();
            oAuto.TopLevel = false;
            panel.Controls.Add(oAuto);
            oAuto.Show();
        }

        private void kierowcyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmKierowcyTab oKier = new frmKierowcyTab();
            oKier.TopLevel = false;
            panel.Controls.Add(oKier);
            oKier.Show();
        }

        private void pasażerowieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmPasazerTab oPas = new frmPasazerTab();
            oPas.TopLevel = false;
            panel.Controls.Add(oPas);
            oPas.Show();
        }

        private void pasażerowieWKursachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmPasKursTab oPasKurs = new frmPasKursTab();
            oPasKurs.TopLevel = false;
            panel.Controls.Add(oPasKurs);
            oPasKurs.Show();
        }

        private void użytkownicyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmAdminTab oUzyt = new frmAdminTab();
            oUzyt.TopLevel = false;
            panel.Controls.Add(oUzyt);
            oUzyt.Show();
        }

        private void tsb_harm_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmHarmoRuchu oHR = new frmHarmoRuchu();
            oHR.TopLevel = false;
            panel.Controls.Add(oHR);
            oHR.Show();
        }

        private void Administrator_FormClosing(object sender, FormClosingEventArgs e)
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
