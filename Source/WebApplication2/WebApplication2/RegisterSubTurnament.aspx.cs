using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Turnament_NameSpace;

namespace WebApplication2
{
    public partial class RegisterSubTurnament : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TurnamentHandler.ViewTurnaments(ListBoxTurnaments);
        }

        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            Turnament parentT = TurnamentHandler.FindTurnament(TextBoxParent.Text);
            if(parentT != null)
            {
               if( TurnamentHandler.IsNameFine(TextBoxSub.Text))
                {
                    int newDepth = parentT.depth + 1;
                    if (newDepth < 10)
                    {
                        Turnament subT = new Turnament(newDepth, TextBoxSub.Text,parentT.name);
                        parentT.subTurnaments.Add(subT);
                        TurnamentHandler.ViewTurnaments(ListBoxTurnaments);
                        TextBoxParent.Text = subT.name;
                        LabelResult.Text = "Success";
                    }
                    else
                    {
                        LabelResult.Text = "Can not go lower than level 10 depth";
                    }
                }
                else
                {
                    LabelResult.Text = "Please enter another name for the new subturnament";
                }
            }

            else
            {
                LabelResult.Text = "Could not find parent turnament, is the spelling correct?";
            }

        }
        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainPage.aspx");
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonRefresh_Click(object sender, EventArgs e)
        {
            TurnamentHandler.ViewTurnaments(ListBoxTurnaments);
        }
    }
}