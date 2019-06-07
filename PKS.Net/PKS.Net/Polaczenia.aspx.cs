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
    public partial class Polaczenia : System.Web.UI.Page
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");

        public void DropDownListMiastoS()
        {
            //ddlNazwa.Items.Clear();
            DataTable MIEJSCOWOŚCI = new DataTable();
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("Select Id_Miejscowości, M_Nazwa from MIEJSCOWOŚCI", sqlcon);
                adp.Fill(MIEJSCOWOŚCI);

                ddlMiastoS.DataSource = MIEJSCOWOŚCI;
                ddlMiastoS.DataTextField = "M_Nazwa";
                ddlMiastoS.DataValueField = "Id_Miejscowości";
                ddlMiastoS.DataBind();
            }
            catch (Exception ex)
            {
                LblError.Text = ex.ToString();
            }
            sqlcon.Close();
        }

        public void DropDownListMiastoK()
        {
            //ddlNazwa.Items.Clear();
            DataTable MIEJSCOWOŚCI = new DataTable();
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("Select Id_Miejscowości, M_Nazwa from MIEJSCOWOŚCI", sqlcon);
                adp.Fill(MIEJSCOWOŚCI);

                ddlMiastoK.DataSource = MIEJSCOWOŚCI;
                ddlMiastoK.DataTextField = "M_Nazwa";
                ddlMiastoK.DataValueField = "Id_Miejscowości";
                ddlMiastoK.DataBind();
            }
            catch (Exception ex)
            {
                LblError.Text = ex.ToString();
            }
            sqlcon.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownListMiastoK();
            DropDownListMiastoS();
        }

        protected void ButPokaz_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                string query = "select distinct m.M_Nazwa, t.Nazwa, m.Id_Miejscowości from MIEJSCOWOŚCI m inner join ODCINEK od on m.Id_Miejscowości = od.Id_Miejscowości_S inner join ODCINEK odd on m.Id_Miejscowości = odd.Id_Miejscowości_K inner join ODCINEK_TRASY odt on od.Id_Odcinek = odt.Id_Odcinek inner join TRASY t on odt.Id_Trasy = t.Id_Trasy inner join KURSY k on odt.Id_Trasy = k.Id_Trasy where od.Id_Miejscowości_S = @start or od.Id_Miejscowości_K = @koniec";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@start", Convert.ToInt32(ddlMiastoS.SelectedItem.Value));
                cmd.Parameters.AddWithValue("@koniec", Convert.ToInt32(ddlMiastoK.SelectedItem.Value));
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
    }
}