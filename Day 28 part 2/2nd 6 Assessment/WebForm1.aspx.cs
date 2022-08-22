using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2nd_6_Assessment
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var item1 = from ListItem li in ListBox1.Items
                           where li.Selected == true
                           select li.Text;
            var item2 = from ListItem lii in ListBox2.Items
                        where lii.Selected == true
                        select lii.Text;

            var result = item1.Union(item2).ToList();
            foreach(var sel in result)
            {
                Response.Write(sel.ToString() + "</br>");
            }


        }
    }
}