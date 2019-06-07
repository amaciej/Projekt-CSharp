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
    public partial class AutokaryTab : System.Web.UI.Page
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");

        public void Clear()
        {
            hfAutoId.Value = "";
            TextKier.Text = TextIlosc.Text = TextMarka.Text = TextModel.Text = TextNr.Text = TextRok.Text = "";
            LblError.Text = LblSukces.Text = "";
            ButSave.Text = "Zapisz";
            ButUsun.Enabled = false;
        }

        void FillGridView()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Autokary_ViewAll", sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtb = new DataTable();
            sqlDa.Fill(dtb);
            sqlcon.Close();
            gvAuto.DataSource = dtb;
            gvAuto.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ButUsun.Enabled = false;
                FillGridView();
            }
        }

        protected void ButSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                SqlCommand sqlCmd = new SqlCommand("Autokary_AddorEdit", sqlcon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Id_Autokaru", (hfAutoId.Value == "" ? 0 : Convert.ToInt32(hfAutoId.Value)));
                sqlCmd.Parameters.AddWithValue("@Id_Kierowcy", TextKier.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Nr_Rejstracyjny", TextNr.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Ilosc_Miejsc", TextIlosc.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Marka", TextMarka.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Model", TextModel.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Rocznik", TextRok.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                string idMiejsc = hfAutoId.Value;
                Clear();
                if (idMiejsc == "")
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
            SqlCommand sqlCmd = new SqlCommand("AutokaryDeleteById", sqlcon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@Id_Autokaru", Convert.ToInt32(hfAutoId.Value));
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
            SqlDataAdapter sqlDa = new SqlDataAdapter("Autokary_View_by_Id", sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Id_Autokaru", id);
            DataTable dtb = new DataTable();
            sqlDa.Fill(dtb);
            sqlcon.Close();
            hfAutoId.Value = id.ToString();
            TextKier.Text = dtb.Rows[0]["Id_Kierowcy"].ToString();
            TextNr.Text = dtb.Rows[0]["Nr_Rejstracyjny"].ToString();
            TextIlosc.Text = dtb.Rows[0]["Iilość_Miejsc"].ToString();
            TextMarka.Text = dtb.Rows[0]["Marka"].ToString();
            TextModel.Text = dtb.Rows[0]["Model"].ToString();
            TextRok.Text = dtb.Rows[0]["Rocznik"].ToString();
            ButSave.Text = "Edytuj";
            ButUsun.Enabled = true;
        }
    }
}
