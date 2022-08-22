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
           if( bs.InsertFun(id, bname, auth, pub, pri))
            {
                Response.Write("Students Details Added Successfully");
            }
            else
            {
                Response.Write("Students Details Not Added Successfully");
            }

        

    }

        protected void btn_Select_Click(object sender, EventArgs e)
        {
            //if(bs.GetBooksFun())
            //{
            //    Response.Write("All Students Below");
            //}
            //else
            //{
            //    Response.Write("Unable to show students");
            //}
         var res =    bs.GetBooksFun();
            GridView1.DataSource = res;
            GridView1.DataBind();
          
        }

        protected void btn_Update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBox1.Text);
            string bname = TextBox2.Text;
           
            if(bs.UpdateFun(id, bname))
            {
                Response.Write("Students Details Updated Successfully");
            }
            else
            {
                Response.Write("Students Details Not Updated Successfully");
            }

       
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBox1.Text);
           if( bs.DeleteBookFun(id))
            {
                Response.Write("Students Deleted Successfully");
            }
            else
            {
                Response.Write("Students Not Deleted Successfully");
            }
        
        }
    }
}