using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PKS.Net
{
    public partial class Logowanie : System.Web.UI.Page
    {
        public string conString = "Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            LblError.Visible = false;
        }

        protected void ButLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(conString);
            sqlcon.Open();
            string q1 = "Select count(1) from UŻYTKOWNICY where Id_Upr = 1 and Login = '" + TextLogin.Text.Trim() + "' and Hasło = '" + TextHaslo.Text.Trim() + "'";
            SqlCommand sqlCmd = new SqlCommand(q1, sqlcon);
            string q2 = "Select count(1) from UŻYTKOWNICY where Id_Upr = 2 and Login = '" + TextLogin.Text.Trim() + "' and Hasło = '" + TextHaslo.Text.Trim() + "'";
            SqlCommand sqlCmd2 = new SqlCommand(q2, sqlcon);
            string q3 = "Select count(1) from UŻYTKOWNICY where Id_Upr = 3 and Login = '" + TextLogin.Text.Trim() + "' and Hasło = '" + TextHaslo.Text.Trim() + "'";
            SqlCommand sqlCmd3 = new SqlCommand(q3, sqlcon);
            string q4 = "Select count(1) from UŻYTKOWNICY where Id_Upr = 4 and Login = '" + TextLogin.Text.Trim() + "' and Hasło = '" + TextHaslo.Text.Trim() + "'";
            SqlCommand sqlCmd4 = new SqlCommand(q4, sqlcon);
            int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
            int count2 = Convert.ToInt32(sqlCmd2.ExecuteScalar());
            int count3 = Convert.ToInt32(sqlCmd3.ExecuteScalar());
            int count4 = Convert.ToInt32(sqlCmd4.ExecuteScalar());

            if (count == 1)
            {
                Session["Login"] = TextLogin.Text.Trim();
                Response.Redirect("Admininstrator.aspx");

            }
            else if (count2 == 1)
            {
                Session["Login"] = TextLogin.Text.Trim();
                Response.Redirect("Dyspozytor.aspx");

            }
            else if (count3 == 1)
            {
                Session["Login"] = TextLogin.Text.Trim();
                Response.Redirect("Kierowca.aspx");

            }
            else if (count4 == 1)
            {
                Session["Login"] = TextLogin.Text.Trim();
                Response.Redirect("Pasazer.aspx");
            }
            else
            {
                LblError.Visible = true;
            }
        }
    }
}