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
    public partial class frmMiejscowosciTab : Form
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");
        int Id_Miejscowosci = 0;
        public frmMiejscowosciTab()
        {
            InitializeComponent();
        }

        private void but_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id_Miejscowości", Id_Miejscowosci);
                param.Add("@Nazwa", txt_Nazwa.Text.Trim());

                sqlcon.Execute("Miejscjowosci_AddorEdit", param, commandType: CommandType.StoredProcedure);
                WyswietlDane();
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

        void WyswietlDane()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@szukajText", txt_szukaj.Text.Trim());

            List<MIEJSCOWOŚCI> list = sqlcon.Query<MIEJSCOWOŚCI>("Miejscowosci_ViewAllorSearch", param, commandType: CommandType.StoredProcedure).ToList<MIEJSCOWOŚCI>();

            dgvMiesjsc.DataSource = list;
        }

        class MIEJSCOWOŚCI
        {
            public int Id_Miejscowości { get; set; }
            public string M_Nazwa { get; set; }
            
        }

        private void frmMiejscowosciTab_Load(object sender, EventArgs e)
        {
            try
            {
                WyswietlDane();
                Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void but_szukaj_Click(object sender, EventArgs e)
        {
            try
            {
                WyswietlDane();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Clear()
        {
            txt_IdMiej.Text = txt_Nazwa.Text = txt_szukaj.Text = "";
            Id_Miejscowosci = 0;
            but_save.Text = "Zapisz";
            but_usun.Enabled = false;
        }

        private void but_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvMiesjsc_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvMiesjsc.CurrentRow.Index != -1)
                {
                    Id_Miejscowosci = Convert.ToInt32(dgvMiesjsc.CurrentRow.Cells[0].Value.ToString());
                    txt_IdMiej.Text = dgvMiesjsc.CurrentRow.Cells[0].Value.ToString();
                    txt_Nazwa.Text = dgvMiesjsc.CurrentRow.Cells[1].Value.ToString();
                    but_usun.Enabled = true;
                    but_save.Text = "Edytuj";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void but_usun_Click(object sender, EventArgs e)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id_Miejscwości", Id_Miejscowosci);
                sqlcon.Execute("MiejscowosciDeleteById", param, commandType: CommandType.StoredProcedure);
                Clear();
                WyswietlDane();
                MessageBox.Show("Usunięto poprawnie");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
