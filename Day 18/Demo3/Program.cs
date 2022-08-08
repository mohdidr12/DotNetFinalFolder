using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source=DEL1-LHP-N82101\\MSSQLSERVER01;Initial Catalog=Northwind;Integrated Security=SSPI");
            string sql = "Select ProductName,UnitPrice from Products where UnitPrice<20";
            try
            {
                // Sql Command cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Products");

                DataTable dt = ds.Tables["Products"];




                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                        Console.WriteLine(row[col]);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //write code here to handle exception
            }
        }
    }
}
