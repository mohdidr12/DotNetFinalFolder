using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace StoredProcedureDemo
{
     class Program
    {
        static void Main(string[] args)
        {
            Program spd = new Program();
            //run a simple  stored procedure
            spd.RunStoredProc();
            //run a stored procedure that takes a parameter
            //spd.RunStoredProcParams();
         }
        //runs a simple stored procedure
        public void RunStoredProc()
        {
            SqlConnection conn =null;
            SqlDataReader rdr = null;
            Console.WriteLine("Top 10 Most Expensive Products\n");

        
            try
            {
                //create and open a connection object
                conn = new SqlConnection("Server=DEL1-LHP-N82101\\MSSQLSERVER01;DataBase=Northwind;Integrated Security=SSPI");
                conn.Open();
                //1. create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("ten most expensive products",conn);
                //2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;
                //execute the command
                rdr = cmd.ExecuteReader();
                //iterate through the results , printing each console
                while(rdr.Read())
                {
                    Console.WriteLine("Product:{0,-25}Price:${1,6:####.00}",rdr["TenMostExpensiveProducts"],rdr["UnitPrice"]);

                }
              }
            finally
            {
                if(conn!=null)
                {
                    conn.Close();
                }
                if(rdr!=null)
                {
                    rdr.Close();
                }
            }

            }
        }
}

