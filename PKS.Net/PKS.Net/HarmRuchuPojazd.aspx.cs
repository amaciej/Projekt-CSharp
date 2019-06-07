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
    public partial class HarmRuchuPojazd : System.Web.UI.Page
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");

        public void Clear()
        {
            hfKursId.Value = "";
            TextId.Text = "";
            LblError.Text ="";
        }

        void FillGridView()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Kursy_ViewAll", sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtb = new DataTable();
            sqlDa.Fill(dtb);
            sqlcon.Close();
            gvKursy.DataSource = dtb;
            gvKursy.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillGridView();
            }
        }

        void WyswietlHarm()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            string query = "select mS.M_Nazwa as Miejscowość_S, mK.M_Nazwa as Miejscowości_K, od.Godz_Początek, od.Godz_Koniec, a.Id_Autokaru from ODCINEK od join MIEJSCOWOŚCI mS on od.Id_Miejscowości_S = mS.Id_Miejscowości join MIEJSCOWOŚCI  mK on od.Id_Miejscowości_K = mK.Id_Miejscowości join ODCINEK_TRASY odt on od.Id_Odcinek = odt.Id_Odcinek join KURSY k on odt.Id_Trasy = k.Id_Trasy join AUTOKARY a on k.Id_Autokaru = a.Id_Autokaru where k.Id_Kursy = " + TextId.Text;
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            sqlcon.Close();
            gvHarm.DataSource = dt;
            gvHarm.DataBind();

        }

        protected void ButPokaz_Click(object sender, EventArgs e)
        {
            try
            {
                WyswietlHarm();
            }
            catch (Exception ex)
            {
                LblError.Text = ex.Message;
            }
        }
    }
}