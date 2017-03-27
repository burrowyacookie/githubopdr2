using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OPDRACHT2READER
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnMaakKaart_Click(object sender, EventArgs e)
        {
            string Naam, Geslacht, Hobby, Opleiding;
            Naam = txtNaam.Text;
            Geslacht = rbGeslacht.SelectedValue;
            Opleiding = cbOpleiding.SelectedValue;
            Hobby = "Hobby: ";

            if (chkHobby.SelectedValue == "1")
            {
                Hobby += "Films ";
            }

            if (chkHobby.SelectedValue == "2")
            {
                Hobby += "Gitaar";
            }
            string Labelinfo = "Naam: " + "<br />" + Hobby + "<br />"
                 + "Opleiding: " + Opleiding + "<br />" + "Geslacht: " + Geslacht + "<br />";
            Info.Text = Labelinfo;
        }

        protected void Listing_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}