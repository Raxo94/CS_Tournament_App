using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAddPlayer_Click(object sender, EventArgs e)
        {
            //Response.Redirect("Webform1.aspx");
            RestClient_Namespace.RestClient rClient = new RestClient_Namespace.RestClient();
            rClient.endPoint = TextBoxAge.Text;
            string strResponse = string.Empty;
            strResponse = rClient.makeRequest();
            TextBoxName.Text = strResponse;

        }
    }
}