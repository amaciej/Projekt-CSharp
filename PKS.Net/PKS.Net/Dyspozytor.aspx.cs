using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PKS.Net
{
    public partial class Dyspozytor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButWyloguj_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Logowanie.aspx");
        }

        protected void ButMiejsc_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("MiastaTab.aspx");
        }

        protected void ButOdcinek_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("OdcinekTab.aspx");
        }

        protected void ButOdcinekTrasa_Click(object sender, EventArgs e)
        {

        }

        protected void ButTras_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("TrasaTab.aspx");
        }

        protected void ButKurs_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("KursyTab.aspx");
        }

        protected void ButHarm_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("HarmRuchuPojazd.aspx");
        }

        protected void ButKierTrasa_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("RapKierTrasa.aspx");
        }

        protected void ButIloPas_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("RapIloPas.aspx");
        }
    }
}