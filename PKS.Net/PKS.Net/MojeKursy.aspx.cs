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
    public partial class MojeKursy : System.Web.UI.Page
    {
        public SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-3MI2ANO;Initial Catalog=Baza_kursów;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButPokaz_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                string query = "select t.Nazwa, k.Godz_Początek, k.Godz_Koniec, a.Id_Autokaru, a.Marka, a.Model from KURSY k inner join TRASY t on k.Id_Trasy = t.Id_Trasy inner join AUTOKARY a on k.Id_Autokaru = a.Id_Autokaru inner join PASAŻEROWIE_KURSY pk on k.Id_Kursy = pk.Id_Kursy inner join PASAŻEROWIE p on pk.Id_Pasażer = p.Id_Pasażer where p.Imię = @Imie and p.Nazwisko = @Nazwisko";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@Imie", TextImie.Text.Trim());
                cmd.Parameters.AddWithValue("@Nazwisko", TextNazw.Text.Trim());
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                sqlcon.Close();
                dgvRap.DataSource = dt;
                dgvRap.DataBind();
            }
            catch (Exception ex)
            {
                LblError.Text = ex.Message;
            }
        }
    }
}