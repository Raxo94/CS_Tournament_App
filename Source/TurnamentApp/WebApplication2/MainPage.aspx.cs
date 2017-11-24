using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Turnament_NameSpace;
namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            TurnamentHandler.ViewTurnaments(ListBoxTurnaments);
            TurnamentHandler.ViewPlayers(ListBoxPlayers);
        }
        

        protected void ButtonHandlePlayers_Click(object sender, EventArgs e)
        {
            Response.Redirect("HandlePlayers.aspx");
        }


        protected void ButtonHandleTurnament_Click(object sender, EventArgs e)
        {
            Response.Redirect("HandleTurnaments.aspx");
        }

        protected void ButtonRefresh_Click(object sender, EventArgs e)
        {
            TurnamentHandler.ViewTurnaments(ListBoxTurnaments);
            TurnamentHandler.ViewPlayers(ListBoxPlayers);
        }

       

        protected void ClearTurnaments_Click(object sender, EventArgs e)
        {
            TurnamentHandler.ClearTurnaments();
            TurnamentHandler.ViewTurnaments(ListBoxTurnaments);
            TurnamentHandler.ViewPlayers(ListBoxPlayers);
        }

        protected void ButtonClearPlayers_Click(object sender, EventArgs e)
        {
            TurnamentHandler.Players.Clear();
        }
    }
}