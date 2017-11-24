using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Turnament_NameSpace;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TurnamentHandler.ViewPlayers(ListBoxPlayers);
        }

        protected void ButtonAddPlayer_Click(object sender, EventArgs e)
        {
            int age = 0;
            Int32.TryParse(TextBoxAge.Text,out age);
            if (age > 0)
            {
                if (TurnamentHandler.IsPlayerNameFine(TextBoxName.Text))
                {
                    Player temp = new Player(TextBoxName.Text, age);
                    TurnamentHandler.Players.Add(temp);
                    TurnamentHandler.ViewPlayers(ListBoxPlayers);
                    LabelResult.Text = "Success";
                }
                else
                {
                    LabelResult.Text = "Name is invalid or already taken";
                }
            }
            else
            {
                LabelResult.Text = "Please enter a valid age";
            }

            TurnamentHandler.ViewPlayers(ListBoxPlayers);
            


        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainPage.aspx");
        }

        protected void ButtonRefresh_Click(object sender, EventArgs e)
        {
            TurnamentHandler.ViewPlayers(ListBoxPlayers);
        }

        protected void ButtonEdit_Click(object sender, EventArgs e)
        {
            Player p = TurnamentHandler.FindPlayer(TextBoxCurrentName.Text);
            if (p!=null)
            {
                int newAge = 0;
                Int32.TryParse(TextBoxNewAge.Text, out newAge);
                if (newAge > 0)
                {
                    if (TurnamentHandler.IsPlayerNameFine(TextBoxNewName.Text, p.name))
                    {
                        p.name = TextBoxNewName.Text;
                        p.age = newAge;
                    }
                    else
                    {

                    }
                }
                else
                {
                    LabelResult.Text = "Please enter a valid age";
                }

            }
            else
            {
                LabelResult.Text = "Did not find Player to edit";
            }
            TurnamentHandler.ViewPlayers(ListBoxPlayers);
        }
    }
}