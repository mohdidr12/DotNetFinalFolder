using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConnectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlDataReader rdr = null;
            string CS = "data source=DEL1-LHP-N82101\\MSSQLSERVER01;database=Northwind;integrated security=SSPI";
            SqlConnection conn = new SqlConnection(CS);
            try
            {
               
                SqlCommand cmd = new SqlCommand("Select CustomerID,CompanyName,ContactName from Customers", conn);
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    for (int i= 0;i < 3;i++)
                    {
                        Console.WriteLine(rdr[i]);
                    }
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

        }
    }
}
