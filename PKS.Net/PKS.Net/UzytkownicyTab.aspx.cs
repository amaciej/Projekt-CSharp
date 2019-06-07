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
    public partial class UzytkownicyTab : System.Web.UI.Page
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");

        public void Clear()
        {
            hfUzytId.Value = "";
            TextHaslo.Text = TextLogin.Text = TextUpr.Text = "";
            LblError.Text = LblSukces.Text = "";
            ButSave.Text = "Zapisz";
            ButUsun.Enabled = false;
        }

        void FillGridView()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Uzytkownicy_ViewAll", sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtb = new DataTable();
            sqlDa.Fill(dtb);
            sqlcon.Close();
            gvUzyt.DataSource = dtb;
            gvUzyt.DataBind();
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
                SqlCommand sqlCmd = new SqlCommand("Uzytkownicy_AddorEdit", sqlcon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Id_Uzyt", (hfUzytId.Value == "" ? 0 : Convert.ToInt32(hfUzytId.Value)));
                sqlCmd.Parameters.AddWithValue("@Id_Upr", TextUpr.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Login", TextLogin.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Haslo", TextHaslo.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                string idMiejsc = hfUzytId.Value;
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
            SqlCommand sqlCmd = new SqlCommand("Uzytkownicy_DeleteById", sqlcon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@Id_Uzyt", Convert.ToInt32(hfUzytId.Value));
            sqlCmd.ExecuteNonQuery();
            sqlcon.Close();
            Clear();
            FillGridView();
            LblError.Text = "Usunięto Poprawnie";
        }

        protected void ButClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        protected void lnk_OnClick(object sender, EventArgs e)
        {
            int idTrasa = Convert.ToInt32((sender as LinkButton).CommandArgument);
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Uzytkownicy_ViewAll_by_Id", sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Id_Uzyt", idTrasa);
            DataTable dtb = new DataTable();
            sqlDa.Fill(dtb);
            sqlcon.Close();
            hfUzytId.Value = idTrasa.ToString();
            TextUpr.Text = dtb.Rows[0]["Id_Upr"].ToString();
            TextLogin.Text = dtb.Rows[0]["Login"].ToString();
            TextHaslo.Text = dtb.Rows[0]["Hasło"].ToString();
            ButSave.Text = "Edytuj";
            ButUsun.Enabled = true;
        }
    }
}