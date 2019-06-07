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
    public partial class PasazerKursTab : System.Web.UI.Page
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");

        public void Clear()
        {
            hfPasKursId.Value = "";
            TextKurs.Text = TextPas.Text = "";
            LblError.Text = LblSukces.Text = "";
            ButSave.Text = "Zapisz";
            ButUsun.Enabled = false;
        }

        void FillGridView()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("PasazerowieKursy_ViewAll", sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtb = new DataTable();
            sqlDa.Fill(dtb);
            sqlcon.Close();
            gvPasKurs.DataSource = dtb;
            gvPasKurs.DataBind();
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
                SqlCommand sqlCmd = new SqlCommand("PasazerowieKursy_AddorEdit", sqlcon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Id_PasKurs", (hfPasKursId.Value == "" ? 0 : Convert.ToInt32(hfPasKursId.Value)));
                sqlCmd.Parameters.AddWithValue("@Id_Kursy", TextKurs.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Id_Pasazer", TextPas.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                string idMiejsc = hfPasKursId.Value;
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
            SqlCommand sqlCmd = new SqlCommand("PasazerowieKursy_DeleteById", sqlcon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@IdPasKurs", Convert.ToInt32(hfPasKursId.Value));
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
            SqlDataAdapter sqlDa = new SqlDataAdapter("PasazerowieKursy_ViewAll_by_Id", sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Id_PasKurs", idTrasa);
            DataTable dtb = new DataTable();
            sqlDa.Fill(dtb);
            sqlcon.Close();
            hfPasKursId.Value = idTrasa.ToString();
            TextKurs.Text = dtb.Rows[0]["Id_Kursy"].ToString();
            TextPas.Text = dtb.Rows[0]["Id_Pasażer"].ToString();
            ButSave.Text = "Edytuj";
            ButUsun.Enabled = true;
        }
    }
}