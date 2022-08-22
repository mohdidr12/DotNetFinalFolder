using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace SqlDataAdapterDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           


      }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["demo_1ConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(str))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("GetStudentCourseByIds", conn);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@stId", txt_StId.Text);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@cId", txt_CId.Text);

                DataSet dt = new DataSet();
                sqlDataAdapter.Fill(dt);
                dt.Tables[0].TableName = "Students";
                dt.Tables[1].TableName = "Courses";

                GridView1.DataSource = dt.Tables["Students"];
                GridView1.DataBind();

                GridView2.DataSource = dt.Tables["Courses"];
                GridView2.DataBind();
            }


        }
    }

        
 }
