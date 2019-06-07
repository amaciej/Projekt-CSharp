using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PKS.Net
{
    public partial class Kierowca : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButWyloguj_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Logowanie.aspx");
        }

        protected void ButInfo_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("RapKier.aspx");
        }

        protected void ButIloPas_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("RapIloPas.aspx");
        }
    }
}