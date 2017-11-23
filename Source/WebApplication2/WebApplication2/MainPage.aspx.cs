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
        }
        

        protected void ButtonRegisterPlayer_Click(object sender, EventArgs e)
        {
          
        }

        protected void ButtonRegisterTurnament_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterTurnament.aspx");
        }

        protected void ButtonRefresh_Click(object sender, EventArgs e)
        {
            TurnamentHandler.ViewTurnaments(ListBoxTurnaments);
        }

        protected void ButtonRegisterSubTurnament_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterSubTurnament.aspx");
        }

        protected void ClearTurnaments_Click(object sender, EventArgs e)
        {
            TurnamentHandler.ClearTurnaments();
            TurnamentHandler.ViewTurnaments(ListBoxTurnaments);
        }
    }
}