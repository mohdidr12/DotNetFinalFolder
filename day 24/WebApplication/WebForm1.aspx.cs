using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace WebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public SqlConnection con;
        public string query;
        public void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["emplogin"].ToString();
            con = new SqlConnection(constr);
            con.Open();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            usertxt.Text = "";
            passtxt.Text = "";
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            connection();
            query = "Emplogin";
            SqlCommand com = new SqlCommand(query, con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Usename", usertxt.Text.ToString());
            com.Parameters.AddWithValue("@Password", passtxt.Text.ToString());

            int usercount = (int)com.ExecuteScalar();
            if (usercount == 1)
            {
                Response.Redirect("WelcomeIdris.aspx");

            }
            else
            {
                con.Close();
                Label2.Visible = true;
                Label2.Text = "Invalid User Name or Password";

            }

        }

    }
}