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
    public partial class RapKierTrasa : System.Web.UI.Page
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");

        void WyswitlRap()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                string query = "select distinct KIEROWCY.Id_Kierowcy, KIEROWCY.Imię, KIEROWCY.Nazwisko  from KIEROWCY inner join AUTOKARY on KIEROWCY.Id_Kierowcy = AUTOKARY.Id_Kierowcy inner join KURSY on AUTOKARY.Id_Autokaru = KURSY.Id_Autokaru inner join ODCINEK_TRASY on KURSY.Id_Trasy = ODCINEK_TRASY.Id_Trasy inner join ODCINEK on ODCINEK_TRASY.Id_Odcinek = ODCINEK.Id_Odcinek where ODCINEK.Godz_Początek > @time order by KIEROWCY.Id_Kierowcy ";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@time", TextCzas.Text.Trim());
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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButPokaz_Click(object sender, EventArgs e)
        {
            WyswitlRap();
        }
    }
}