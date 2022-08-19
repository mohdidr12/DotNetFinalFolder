using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication3
{
    public partial class GridViewDemo : System.Web.UI.Page
    {
        SqlConnection conn;
        public GridViewDemo()
        {
            conn = new SqlConnection("Server = DEL1-LHP-N82101\\MSSQLSERVER01; Database = demo_1; Integrated Security = SSPI");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Label1.Text = "Students Add Successfully";
                Label1.Visible = true;
                conn.Open();
                SqlCommand cmd = new SqlCommand($"insert into StudentTable values('{txtId.Text}','{txtName.Text}','{txtStandard.Text}')", conn);
               
                cmd.ExecuteNonQuery();
               
                Response.Redirect("GridViewDemo.aspx");
            }
            
            finally
            {
                conn.Close();
            }
            
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Label1.Text = "Student Updated Successfully";
                Label1.Visible = true;
                conn.Open();
                SqlCommand cmd = new SqlCommand($"Update StudentTable set StudentName='{txtName.Text}'where StudentID='{txtId.Text}'", conn);

                cmd.ExecuteNonQuery();

                Response.Redirect("GridViewDemo.aspx");
            }

            finally
            {
                conn.Close();
            }

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Label1.Text = "Student Deleted Successfully";
                Label1.Visible = true;
                conn.Open();
                SqlCommand cmd = new SqlCommand($"Delete from StudentTable where StudentID='{txtId.Text}'", conn);

                cmd.ExecuteNonQuery();

                Response.Redirect("GridViewDemo.aspx");
            }

            finally
            {
                conn.Close();
            }

        }

       

        }
    }
