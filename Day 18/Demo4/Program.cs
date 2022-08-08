using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            string inputCity = "London";
            try
            {
                conn = new SqlConnection("Server=DEL1-LHP-N82101;DataBase=Northwind;Integrated Security=SSPI");
                conn.Open();


                //SqlCommand cmd = new SqlCommand(
                //"select * from Customers where city=""+inputCity+".",conn);
                //1. Declare Command Object with parameter /define the parameter in the Sql command string
                SqlCommand cmd = new SqlCommand("Select * from Customers where city=@City", conn);

                //2. define parameters used in command object with parameter /define the parameter in the SqlCommand command string
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@City";
                param.Value = inputCity;
                cmd.Parameters.Add(param);
                //get data stream
                reader = cmd.ExecuteReader();
                //write each record
                while (reader.Read())
                {
                    Console.WriteLine(reader["CompanyName"] + "___Company belongs  to---------->" + reader["ContactName"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
             finally
            {
                if(reader!=null)
                {
                    reader.Close();
                }
                if(conn!=null)
                {
                    conn.Close();
                }
            }

            }
        }
    }

