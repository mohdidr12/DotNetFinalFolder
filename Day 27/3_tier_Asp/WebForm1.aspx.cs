using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
namespace _3_tier_Asp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ClsBusLayer objBLL = new ClsBusLayer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
            objBLL.InsertNewUser(txtName.Text, txtAddress.Text, txtCity.Text, txtEmail.Text);
            Response.Redirect("Webform1.aspx");
            //for select record and bind to gridview
            //GridView1.DataSource = objBLL.SelectUser();
            //GridView1.DataBind();

        }
    }
}