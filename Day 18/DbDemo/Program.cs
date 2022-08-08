using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DbDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Instantiate the connection
            SqlConnection conn = new SqlConnection("Data Source=DEL1-LHP-N82101\\MSSQLSERVER01;Initial Catalog=Northwind;Integrated Security=SSPI");
            SqlDataReader rdr = null;
            try
            {
                //2. Open the connection
                conn.Open();
                // 3. pass the Connection to a command object
                SqlCommand cmd = new SqlCommand("Select * from Customers", conn);

                // 4. use the connection

                //get query results
                rdr = cmd.ExecuteReader();
                // print the CustomerID of each record
                while(rdr.Read())
                {
                    Console.WriteLine(rdr[0]);
                }
            }
            finally
            {
                if(rdr!=null)
                {
                    rdr.Close();
                }
                if(conn!=null)
                {
                    conn.Close();
                }
            }
            Console.ReadLine();

        }
    }
}
