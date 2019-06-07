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
    public partial class MiastaTab : System.Web.UI.Page
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ButUsun.Enabled = false;
                FillGridView();
            }            
        }

        protected void ButClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            hfMiejscId.Value = "";
            TextNazwa.Text = "";
            LblError.Text = LblSukces.Text = "";
            ButSave.Text = "Zapisz";
            ButUsun.Enabled = false;
        }

        void FillGridView()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Miejscowosci_ViewAll", sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtb = new DataTable();
            sqlDa.Fill(dtb);
            sqlcon.Close();
            gvMiejsc.DataSource = dtb;
            gvMiejsc.DataBind();
        }

        protected void ButSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                SqlCommand sqlCmd = new SqlCommand("Miejscjowosci_AddorEdit", sqlcon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Id_Miejscowości",(hfMiejscId.Value==""?0:Convert.ToInt32(hfMiejscId.Value)));
                sqlCmd.Parameters.AddWithValue("@Nazwa",TextNazwa.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                string idMiejsc = hfMiejscId.Value;
                Clear();
                if (idMiejsc == "")
                    LblSukces.Text = "Zapisano Poprawnie";
                else
                    LblSukces.Text = "Zedytowano Poprawnie";
                FillGridView();
            }
            catch (Exception ex)
            {

               // MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        protected void lnk_OnClick(object sender,EventArgs e)
        {
            int idMiejsc = Convert.ToInt32((sender as LinkButton).CommandArgument);
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Miejscowosci_ViewById", sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Id_Miejscowości", idMiejsc);
            DataTable dtb = new DataTable();
            sqlDa.Fill(dtb);
            sqlcon.Close();
            hfMiejscId.Value = idMiejsc.ToString();
            TextNazwa.Text = dtb.Rows[0]["M_Nazwa"].ToString();
            ButSave.Text = "Edytuj";
            ButUsun.Enabled = true;
        }

        protected void ButUsun_Click(object sender, EventArgs e)
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlCommand sqlCmd = new SqlCommand("MiejscowosciDeleteById", sqlcon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@Id_Miejscwości", Convert.ToInt32(hfMiejscId.Value));
            sqlCmd.ExecuteNonQuery();
            sqlcon.Close();
            Clear();
            FillGridView();
            LblError.Text = "USunięto Poprawnie";
        }
    }
}