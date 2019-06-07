using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PKS.Net
{
    public partial class Admininstrator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["Login"] == null)
            //    Response.Redirect("Logowanie.aspx");
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

        protected void ButAuto_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("AutokaryTab.aspx");
        }

        protected void ButKierowcy_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("KierowcyTab.aspx");
        }

        protected void ButPas_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("PasazerTab.aspx");
        }

        protected void ButPaswKurs_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("PasazerKursTab.aspx");
        }

        protected void ButUsers_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("UzytkownicyTab.aspx");
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

        protected void ButPol_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Polaczenia.aspx");
        }
    }
}