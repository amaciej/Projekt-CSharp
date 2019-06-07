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
    public partial class OdcinekTab : System.Web.UI.Page
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");
        SqlDataReader reader;

        public void DropDownListPoczątek()
        {
            //sqlcon.Open();
            //string query = "select * from MIEJSCOWOŚCI";
            //SqlCommand sc = new SqlCommand(query, sqlcon);
            ////reader = sc.ExecuteReader();

            ////while (reader.Read())
            ////{
            ////    ListItem newItem = new ListItem();
            ////    newItem.Text = reader["M_Nazwa"].ToString();
            ////    newItem.Value = reader["Id_Miejscowości"].ToString();
            ////    ddlMiastoS.Items.Add(newItem);
            ////}
            //ddlMiastoS.DataSource = sc.ExecuteReader();
            //ddlMiastoS.DataTextField = "M_Nazwa";
            //ddlMiastoS.DataValueField = "Id_Miejscowości";
            //ddlMiastoS.DataBind();
            ////reader.Close();
            //sqlcon.Close();
            //ddlMiastoS.Items.Clear();
            DataTable MIEJSCOWOŚCI = new DataTable();
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            //using (sqlcon)
            //{
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("Select * from MIEJSCOWOŚCI", sqlcon);
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
            //ddlMiastoS.Items.Insert(0, new ListItem("<Wybierz miasto>", "0"));
            //}
            sqlcon.Close();
        }

        public void DropDownListKoniec()
        {
            //sqlcon.Open();
            //string query = "select * from MIEJSCOWOŚCI";
            //SqlCommand sc = new SqlCommand(query, sqlcon);
            //reader = sc.ExecuteReader();

            //while (reader.Read())
            //{
            //    ListItem newItem = new ListItem();
            //    newItem.Text = reader["M_Nazwa"].ToString();
            //    newItem.Value = reader["Id_Miejscowości"].ToString();
            //    ddlMiastoK.Items.Add(newItem);
            //}

            //reader.Close();
            //sqlcon.Close();
            //ddlMiastoK.Items.Clear();
            DataTable MIEJSCOWOŚCI = new DataTable();
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            //using (sqlcon)
            //{
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("Select * from MIEJSCOWOŚCI", sqlcon);
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
            //ddlMiastoK.Items.Insert(0, new ListItem("<Wybierz miasto>", "0"));
            //}
            sqlcon.Close();
        }
        public void Clear()
        {
            hfOdcinekId.Value = "";
            TextCena.Text = TextDlugosc.Text = TextGodzK.Text = TextGodzP.Text = "";
            //ddlMiastoS.Text;
            LblError.Text = LblSukces.Text = "";
            ButSave.Text = "Zapisz";
            ButUsun.Enabled = false;
        }

        void FillGridView()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Odcinek_ViewAll", sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtb = new DataTable();
            sqlDa.Fill(dtb);
            sqlcon.Close();
            gvOdcinek.DataSource = dtb;
            gvOdcinek.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //this.ddlMiastoS.Items.Clear();
            //this.ddlMiastoK.Items.Clear();
            DropDownListPoczątek();
            DropDownListKoniec();

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
                //int s = ddlMiastoS.SelectedItem.Value;
                int p  = Convert.ToInt32(ddlMiastoS.SelectedValue);
                int k = Convert.ToInt32(ddlMiastoK.SelectedValue);
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                SqlCommand sqlCmd = new SqlCommand("Odcinek_AddorEdit", sqlcon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Id_Odcinek", (hfOdcinekId.Value == "" ? 0 : Convert.ToInt32(hfOdcinekId.Value)));
                sqlCmd.Parameters.AddWithValue("@Id_Miejscowosci_S", Convert.ToInt32(ddlMiastoS.SelectedItem.Value));
                sqlCmd.Parameters.AddWithValue("@Id_Miejscowosci_K", Convert.ToInt32(ddlMiastoK.SelectedItem.Value));
                sqlCmd.Parameters.AddWithValue("@Dlugosc", TextDlugosc.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Godz_Poczatek", TextGodzP.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Godz_Koniec", TextGodzK.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Cena_Biletu", TextCena.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                string idMiejsc = hfOdcinekId.Value;
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

        protected void ButUsun_Click(object sender, EventArgs e)
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlCommand sqlCmd = new SqlCommand("OdcinekDeleteById", sqlcon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@Id_Odcinek", Convert.ToInt32(hfOdcinekId.Value));
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
            int idOdcinek = Convert.ToInt32((sender as LinkButton).CommandArgument);
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Odcinek_View_By_Id", sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Id_Odcienk", idOdcinek);
            DataTable dtb = new DataTable();
            sqlDa.Fill(dtb);
            sqlcon.Close();
            hfOdcinekId.Value = idOdcinek.ToString();
            ddlMiastoS.Text = dtb.Rows[0]["Id_Miejscowości_S"].ToString();
            ddlMiastoK.Text = dtb.Rows[0]["Id_Miejscowości_K"].ToString();
            TextDlugosc.Text = dtb.Rows[0]["Długość"].ToString();
            TextGodzP.Text = dtb.Rows[0]["Godz_Początek"].ToString();
            TextGodzK.Text = dtb.Rows[0]["Godz_Koniec"].ToString();
            TextCena.Text = dtb.Rows[0]["Cena_Biletu"].ToString();
            ButSave.Text = "Edytuj";
            ButUsun.Enabled = true;
        }
    }
}