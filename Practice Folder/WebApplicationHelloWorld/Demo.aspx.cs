using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationHelloWorld
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //    Response.Write(txtName.Text + "</br>");
            //    Response.Write(IstLocation.SelectedItem.Text + "</br>");
            Session["Name"] = txtName.Text;
            Response.Write(Session["Name"]);

            lblName.Visible = false;
            txtName.Visible = false;
            IstLocation.Visible = false;
            chkASP.Visible = false;
            chkC.Visible = false;
            rdFemale.Visible = false;
            rdMale.Visible = false;
            btnSubmit.Visible = false;


        }
    }
}