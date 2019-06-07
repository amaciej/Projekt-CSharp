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
    public partial class DodajPas : System.Web.UI.Page
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            hfPasId.Value = "";
            TextImie.Text = TextNazw.Text = "";
            LblError.Text = LblSukces.Text = "";
        }

        protected void ButAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                SqlCommand sqlCmd = new SqlCommand("Pasazerowie_AddorEdit", sqlcon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Id_Pasazer", (hfPasId.Value == "" ? 0 : Convert.ToInt32(hfPasId.Value)));
                sqlCmd.Parameters.AddWithValue("@Imie", TextImie.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Nazwisko", TextNazw.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                string idMiejsc = hfPasId.Value;
                Clear();
                if (idMiejsc == "")
                    LblSukces.Text = "Zapisano Poprawnie";
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
    }
}