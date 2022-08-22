using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;

namespace InsertDemo3Tier
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        BusinessAccessClass obj = new BusinessAccessClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBox1.Text);
            string name = TextBox2.Text;
            int std = Convert.ToInt32(TextBox3.Text);
            obj.InsertFun(id, name, std);
            Response.Redirect("WebForm1.aspx");

        }
    }
}