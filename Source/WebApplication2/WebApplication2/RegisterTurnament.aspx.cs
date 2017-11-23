using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestClient_Namespace;

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
                Turnament_NameSpace.Turnament temp = new Turnament_NameSpace.Turnament(TextBoxTurnamentName.Text);
                Startup.TurnamentHandler.turnaments.Add(temp);
                Response.Redirect("MainPage.aspx");
            }

            //    string host = HttpContext.Current.Request.Url.Authority;
            //    string endPoint = "http://" + host + "/api/turnament";
            //    RestClient rClient = new RestClient(endPoint, httpVerb.POST, "{ postData: value}");

            //    string strResponse = string.Empty;
            //    strResponse = rClient.makeRequest();
            //}


        }
    }
}