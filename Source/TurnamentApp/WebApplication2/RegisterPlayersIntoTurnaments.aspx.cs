using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Turnament_NameSpace;

namespace WebApplication2
{
    public partial class RegisterPlayersIntoTurnaments : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            TurnamentHandler.ViewTurnaments(ListBoxTurnaments);
            TurnamentHandler.ViewPlayers(ListBoxPlayers);

        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainPage.aspx");
        }

        protected void ButtonRefresh_Click(object sender, EventArgs e)
        {
            TurnamentHandler.ViewTurnaments(ListBoxTurnaments);
            TurnamentHandler.ViewPlayers(ListBoxPlayers);
        }

        protected void ButtonSelect_Click(object sender, EventArgs e)
        {
            Turnament t = TurnamentHandler.FindTurnament(TextBoxSelectTurnament.Text);
            {
                if (t != null)
                {
                    LabelPlayersInSelectedTurnament.Text = "Players in turnament- " + t.name;
                    t.ShowPlayersInTurnament(ListBoxPlayersInTurnament);
                    LabelResult.Text = "Success";
                    LabelSelectTurnament.Text = "Selected Turnament- " + TextBoxSelectTurnament.Text;

                }
                else
                {
                    LabelResult.Text = "Unable to find turnament";

                }
            }



        }

        protected void ButtonSelectPlayer_Click(object sender, EventArgs e)
        {
            Player p = TurnamentHandler.FindPlayer(TextBoxSelectPlayer.Text);
            if (p != null)
            {
                LabelSelectPlayer.Text = "Selected Player- " + TextBoxSelectPlayer.Text;
                LabelResult.Text = "Success";


            }
            else
            {
                LabelResult.Text = "Unable to find player";
            }

        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            Player p = TurnamentHandler.FindPlayer(TextBoxSelectPlayer.Text);
            Turnament t = TurnamentHandler.FindTurnament(TextBoxSelectTurnament.Text);

            if (p != null && t != null)
            {
                t.AddPlayer(p);
                t.ShowPlayersInTurnament(ListBoxPlayersInTurnament);
            }
        }
        protected void ButtonRemove_Click(object sender, EventArgs e)
        {
            Player p = TurnamentHandler.FindPlayer(TextBoxSelectPlayer.Text);
            Turnament t = TurnamentHandler.FindTurnament(TextBoxSelectTurnament.Text);

            if (p != null && t != null)
            {
                t.RemovePlayer(p);
                t.ShowPlayersInTurnament(ListBoxPlayersInTurnament);
            }
        }
    }
}