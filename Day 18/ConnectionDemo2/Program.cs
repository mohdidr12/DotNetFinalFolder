using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace ConnectionDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source=DEL1-LHP-N82101\\MSSQLSERVER01;Initial Catalog=Northwind;Integrated Security=SSPI");
            try
            {
             // Sql Command cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Customers", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach(DataRow row in dt.Rows)
                    Console.WriteLine("{0}", row["CustomerID"]);
                  

                DataSet ds = new DataSet();
                da.Fill(ds, "CustomerID");

                Console.WriteLine(ds.Tables.Count);
                Console.WriteLine(ds.Tables[0].TableName);
                foreach (DataRow row in ds.Tables["CustomerID"].Rows)
                    Console.WriteLine("{0}", row[0]);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                //write code here to handle exception
            }
        }
    }
}
