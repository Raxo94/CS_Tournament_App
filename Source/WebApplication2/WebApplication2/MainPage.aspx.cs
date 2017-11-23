using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Turnament_NameSpace;
using RestClient_Namespace;
namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        TurnamentController TC;

        protected void Page_Load(object sender, EventArgs e)
        {
            ButtonRefresh_Click(null, null);  
        }
        
        public void InitiateTC()
        {
            TC = new TurnamentController();
        }
        protected void ButtonRegisterPlayer_Click(object sender, EventArgs e)
        {
          
        }

        protected void ButtonRegisterTurnament_Click(object sender, EventArgs e)
        {


            Response.Redirect("RegisterTurnament.aspx");
           


        }

        protected void ListBoxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonRefresh_Click(object sender, EventArgs e)
        {
            //RestClient rClient = new RestClient();
            //rClient.httpMethod = httpVerb.GET;
            //string host = HttpContext.Current.Request.Url.Authority;
            //rClient.endPoint = "http://" + host + "/api/turnament";
            //string strResponse = string.Empty;
            //strResponse = rClient.makeRequest();

            //ListBoxTurnaments.Items.Add(strResponse);


            ListBoxTurnaments.Items.Clear();
            foreach (Turnament t in Startup.TurnamentHandler.turnaments)
            {
                
                ListBoxTurnaments.Items.Add(t.name);
            }
        }

    }
}