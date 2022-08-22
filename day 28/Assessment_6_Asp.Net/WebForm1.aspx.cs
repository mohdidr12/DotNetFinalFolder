using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;

namespace Assessment_6_Asp.Net
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        BusinessAccessClass bs = new BusinessAccessClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBox1.Text);
            string bname = TextBox2.Text;
            string auth = TextBox3.Text;
            string pub = TextBox4.Text;
            double pri = Convert.ToDouble(TextBox5.Text);
            bs.InsertFun(id, bname, auth, pub, pri);
           // Response.Redirect("WebForm1.aspx");

        

    }

        protected void btn_Select_Click(object sender, EventArgs e)
        {
            bs.GetBooksFun();
        //    Response.Redirect("WebForm1.aspx");
        }

        protected void btn_Update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBox1.Text);
            string bname = TextBox2.Text;
            double pri = Convert.ToDouble(TextBox5.Text);
            bs.UpdateFun(id, bname, pri);
       //     Response.Redirect("WebForm1.aspx");
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBox1.Text);
            bs.DeleteBookFun(id);
     //       Response.Redirect("WebForm1.aspx");
        }
    }
}