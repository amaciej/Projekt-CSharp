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
    public partial class KursyTab : System.Web.UI.Page
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");

        public void Clear()
        {
            hfKursId.Value = "";
            TextAuto.Text = TextDni.Text = TextGodzK.Text = TextGodzP.Text = TextIlosc.Text = "";
            LblError.Text = LblSukces.Text = "";
            ButSave.Text = "Zapisz";
            ButUsun.Enabled = false;
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

        public void DropDownList()
        {
            //ddlNazwa.Items.Clear();
            DataTable TRASY = new DataTable();
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("Select Id_Trasy, Nazwa from TRASY", sqlcon);
                adp.Fill(TRASY);

                ddlNazwa.DataSource = TRASY;
                ddlNazwa.DataTextField = "Nazwa";
                ddlNazwa.DataValueField = "Id_Trasy";
                ddlNazwa.DataBind();
            }
            catch (Exception ex)
            {
                LblError.Text = ex.ToString();
            }
            sqlcon.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //DropDownList();
            if (!IsPostBack)
            {
                DropDownList();
                ButUsun.Enabled = false;
                FillGridView();
            }
        }

        protected void ButSave_Click(object sender, EventArgs e)
        {
            try
            {
                string dataP = TextGodzP.Text;
                DateTime dP = DateTime.ParseExact(dataP, "yyyy-MM-dd HH:mm:ss",
                                       System.Globalization.CultureInfo.InvariantCulture);
                string dataK = TextGodzK.Text;
                DateTime dK = DateTime.ParseExact(dataK, "yyyy-MM-dd HH:mm:ss",
                                       System.Globalization.CultureInfo.InvariantCulture);
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                SqlCommand sqlCmd = new SqlCommand("Kursy_AddorEdit", sqlcon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Id_Kursy", (hfKursId.Value == "" ? 0 : Convert.ToInt32(hfKursId.Value)));
                sqlCmd.Parameters.AddWithValue("@Id_Trasy", Convert.ToInt32(ddlNazwa.SelectedItem.Value));
                sqlCmd.Parameters.AddWithValue("@Id_Autokaru", TextAuto.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Dni", TextDni.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Godz_Poczatek", dP);
                sqlCmd.Parameters.AddWithValue("@Godz_Koniec", dK);
                sqlCmd.Parameters.AddWithValue("@Ilosc_Pasazerow", TextIlosc.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                string id = hfKursId.Value;
                Clear();
                if (id == "")
                    LblSukces.Text = "Zapisano Poprawnie";
                else
                    LblSukces.Text = "Zedytowano Poprawnie";
                FillGridView();
            }
            catch (Exception ex)
            {

                LblError.Text = ex.Message;
            }
            finally
            {
                sqlcon.Close();
            }
        }

        protected void ButUsun_Click(object sender, EventArgs e)
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlCommand sqlCmd = new SqlCommand("Kursy_DeleteById", sqlcon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@Id_Kursy", Convert.ToInt32(hfKursId.Value));
            sqlCmd.ExecuteNonQuery();
            sqlcon.Close();
            Clear();
            FillGridView();
            LblError.Text = "USunięto Poprawnie";
        }

        protected void ButClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        protected void lnk_OnClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as LinkButton).CommandArgument);
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Kursy_View_By_Id", sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Id_Kursy", id);
            DataTable dtb = new DataTable();
            sqlDa.Fill(dtb);
            sqlcon.Close();
            hfKursId.Value = id.ToString();
            ddlNazwa.Text = dtb.Rows[0]["Id_Trasy"].ToString();
            TextAuto.Text = dtb.Rows[0]["Id_Autokaru"].ToString();
            TextDni.Text = dtb.Rows[0]["Dni"].ToString();
            TextGodzP.Text = dtb.Rows[0]["Godz_Początek"].ToString();
            TextGodzK.Text = dtb.Rows[0]["Godz_Koniec"].ToString();
            TextIlosc.Text = dtb.Rows[0]["Ilość_Pasażerów"].ToString();
            ButSave.Text = "Edytuj";
            ButUsun.Enabled = true;
        }
    }
}