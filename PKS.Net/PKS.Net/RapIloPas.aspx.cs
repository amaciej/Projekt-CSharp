using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PKS.Net
{
    public partial class RapIloPas : System.Web.UI.Page
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        void WyswitlRap()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                string dataP = TextDataOd.Text;
                DateTime dP = DateTime.ParseExact(dataP, "yyyy-MM-dd HH:mm:ss",
                                       System.Globalization.CultureInfo.InvariantCulture);
                string dataK = TextDataDo.Text;
                DateTime dK = DateTime.ParseExact(dataK, "yyyy-MM-dd HH:mm:ss",
                                       System.Globalization.CultureInfo.InvariantCulture);
                string query = "select count(PASAŻEROWIE_KURSY.Id_Pasażer) as 'Ilość Pasażerów' from PASAŻEROWIE_KURSY inner join KURSY on PASAŻEROWIE_KURSY.Id_Kursy = KURSY.Id_Kursy where PASAŻEROWIE_KURSY.Id_Kursy = " + TextId.Text + " and KURSY.Godz_Początek between @godzP and @godzK";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@godzP", dP);
                cmd.Parameters.AddWithValue("@godzK", dK);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                sqlcon.Close();
                dgvRap.DataSource = dt;
                dgvRap.DataBind();
            }
            catch (Exception ex)
            {
                LblError.Text = ex.Message;
            }
        }

        protected void ButPokaz_Click(object sender, EventArgs e)
        {
            WyswitlRap();
        }
    }
}