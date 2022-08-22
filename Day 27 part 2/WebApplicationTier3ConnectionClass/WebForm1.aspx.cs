using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL_Layer;

namespace WebApplicationTier3ConnectionClass
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        BusinessLayerClass csobj = new BusinessLayerClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
            csobj.InsertNewUser(txtName.Text, txtAddress.Text, txtCity.Text, txtEmail.Text);
           
            Response.Redirect("Webform1.aspx");
        }
    }
}