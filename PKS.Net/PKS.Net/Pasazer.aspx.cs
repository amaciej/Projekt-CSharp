using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PKS.Net
{
    public partial class Pasazer : System.Web.UI.Page
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
            Response.Redirect("DodajPas.aspx");
        }

        protected void ButIloPas_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("MojeKursy.aspx");
        }

        protected void ButHarm_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("HarmRuchuPojazd.aspx");
        }

        protected void ButPolocz_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Polaczenia.aspx");
        }
    }
}