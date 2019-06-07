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
    public partial class KierowcyTab : System.Web.UI.Page
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");

        public void Clear()
        {
            hfKierId.Value = "";
            TextImie.Text = TextNazw.Text = TextPESEL.Text = "";
            LblError.Text = LblSukces.Text = "";
            ButSave.Text = "Zapisz";
            ButUsun.Enabled = false;
        }

        void FillGridView()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Kierowcy_ViewAll", sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtb = new DataTable();
            sqlDa.Fill(dtb);
            sqlcon.Close();
            gvKier.DataSource = dtb;
            gvKier.DataBind();
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
                SqlCommand sqlCmd = new SqlCommand("Kierowcy_AddorEdit", sqlcon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Id_Kierowcy", (hfKierId.Value == "" ? 0 : Convert.ToInt32(hfKierId.Value)));
                sqlCmd.Parameters.AddWithValue("@Imię", TextImie.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Nazwisko", TextNazw.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@PESEL", TextPESEL.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                string idMiejsc = hfKierId.Value;
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
            SqlCommand sqlCmd = new SqlCommand("KierowcyDeleteById", sqlcon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@Id_Kierowcy", Convert.ToInt32(hfKierId.Value));
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
            SqlDataAdapter sqlDa = new SqlDataAdapter("Kierowcy_View_by_Id", sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Id_Kierowcy", id);
            DataTable dtb = new DataTable();
            sqlDa.Fill(dtb);
            sqlcon.Close();
            hfKierId.Value = id.ToString();
            TextImie.Text = dtb.Rows[0]["Imię"].ToString();
            TextNazw.Text = dtb.Rows[0]["Nazwisko"].ToString();
            TextPESEL.Text = dtb.Rows[0]["PESEL"].ToString();
            ButSave.Text = "Edytuj";
            ButUsun.Enabled = true;
        }
    }
}