using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class DemoRedirect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
      
protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("SecondPage.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("SecondPage.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.google.com");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Server.Transfer("https://www.google.com");
        
        /*
         * One of the most important differences is that the Server.Transfer method
         * can only work when the page is at the same sever,
         * Out the response.Redirect method can be tranfered when the server is at a different place
         */
         }
         
    }
}