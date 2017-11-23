using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Turnament_NameSpace;


namespace WebApplication2
{
    public partial class RegisterTurnament : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAddTurnament_Click(object sender, EventArgs e)
        {
            if (TextBoxTurnamentName.Text != "")
            {
                Turnament temp = new Turnament_NameSpace.Turnament(0,TextBoxTurnamentName.Text);
                TurnamentHandler.turnaments.Add(temp);
                Response.Redirect("MainPage.aspx");
            }


        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainPage.aspx");
        }
    }
}