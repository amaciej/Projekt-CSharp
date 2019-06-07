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
    public partial class TrasaTab : System.Web.UI.Page
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");

        public void Clear()
        {
            hfTrasaId.Value = "";
            TextCzas.Text = TextNazwa.Text = "";
            LblError.Text = LblSukces.Text = "";
            ButSave.Text = "Zapisz";
            ButUsun.Enabled = false;
        }

        void FillGridView()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Trasy_ViewAll", sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtb = new DataTable();
            sqlDa.Fill(dtb);
            sqlcon.Close();
            gvTrasa.DataSource = dtb;
            gvTrasa.DataBind();
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
                SqlCommand sqlCmd = new SqlCommand("Trasy_AddorEdit", sqlcon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Id_Miejscowości", (hfTrasaId.Value == "" ? 0 : Convert.ToInt32(hfTrasaId.Value)));
                sqlCmd.Parameters.AddWithValue("@Nazwa", TextNazwa.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Czas_Trasy", TextCzas.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                string idMiejsc = hfTrasaId.Value;
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
            SqlCommand sqlCmd = new SqlCommand("Trasy_DeleteById", sqlcon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@Id_Trasy", Convert.ToInt32(hfTrasaId.Value));
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
            int idTrasa = Convert.ToInt32((sender as LinkButton).CommandArgument);
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Trasy_View_by_Id", sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Id_Trasy", idTrasa);
            DataTable dtb = new DataTable();
            sqlDa.Fill(dtb);
            sqlcon.Close();
            hfTrasaId.Value = idTrasa.ToString();
            TextNazwa.Text = dtb.Rows[0]["Nazwa"].ToString();
            TextCzas.Text = dtb.Rows[0]["Czas_Trasy"].ToString();
            ButSave.Text = "Edytuj";
            ButUsun.Enabled = true;
        }
    }
}