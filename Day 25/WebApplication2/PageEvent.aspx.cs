using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class PageEvent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Log("<<Page_Load>>");

        }
        protected void Page_PreRender(object sender,EventArgs e)
        {
            Log("Page_PreRender");
        }
        protected void CtrlChanged(object sender,EventArgs e)
        {
            string ctrlName = ((Control)sender).ID;
            Log(ctrlName + "Changed");
        }
        private void Log(string entry)
        {
            ListBox1.Items.Add(entry);
            //Select the last item 
            ListBox1.SelectedIndex=ListBox1.Items.Count - 1;
        }
    }
}