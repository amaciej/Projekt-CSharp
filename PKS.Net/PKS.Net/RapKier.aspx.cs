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
    public partial class RapKier : System.Web.UI.Page
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        void PokazKurs()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                string query = "select kier.PESEL as 'Twój PESEL', k.Id_Kursy, t.Nazwa as 'Nazwa Trasy', k.Dni, k.Godz_Początek, k.Godz_Koniec,a.Id_Autokaru, a.Marka, a.Model, a.Nr_Rejstracyjny from KURSY k inner join TRASY t on k.Id_Trasy = t.Id_Trasy inner join AUTOKARY a on k.Id_Autokaru = a.Id_Autokaru inner join KIEROWCY kier on a.Id_Kierowcy = kier.Id_Kierowcy where a.Id_Kierowcy = " + TextId.Text;
                SqlCommand cmd = new SqlCommand(query, sqlcon);
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
            PokazKurs();
        }
    }
}