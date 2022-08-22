using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace DAL_L
{
    public class DataLayerClass
    {
        
        public string strconn = ConfigurationManager.ConnectionStrings["demo_1ConnectionString"].ConnectionString;
        public void InsertData(string _name,string _add,string _city,string _email)
        {
           
            SqlConnection sqlconn = new SqlConnection(strconn);
            SqlDataAdapter sqladapter = new SqlDataAdapter($"insert into tb1_UserDetails values('{_name}','{_add}','{_city}','{_email}')",sqlconn);
            DataTable DT = new DataTable();
            sqladapter.Fill(DT);
            
        }
        public object SelectData()
        {
            SqlConnection sqlconn = new SqlConnection(strconn);

            SqlDataAdapter sqladapter = new SqlDataAdapter("Select * from tb1_UserDetails", sqlconn);
            DataTable DT = new DataTable();
            sqladapter.Fill(DT);
            return DT;
        }
    }
}
