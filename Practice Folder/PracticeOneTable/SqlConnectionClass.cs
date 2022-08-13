using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PracticeOneTable
{
    class SqlConnectionClass : IStudentServiceSql
    {
        SqlConnection conn;
        public SqlConnectionClass()
        {
            conn = new SqlConnection("Server = DEL1-LHP-N82101; Database = SchoolsDb; Integrated Security = SSPI");

        }
        public void AddData(string id,string name,byte age,byte standard,string city)
        {
            try
            {
                conn.Open();
                string str = $"Insert into Student values('{id}','{name}','{age}','{standard}','{city}')";
                SqlCommand cmd = new SqlCommand(str, conn);
                int n = cmd.ExecuteNonQuery();
                if(n>0)
                {
                    Console.WriteLine(n + " rows Inserted");
                }
                else
                {
                    Console.WriteLine("Unable to insert the rows");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(conn!=null)
                {
                    conn.Close();
                }
            }
        }
        public void UpdateAge(string id,byte age)
        {
            try
            {
                conn.Open();
                string str = $"Update Student set Age = '{age}'where id='{id}'";
                SqlCommand cmd = new SqlCommand(str, conn);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    Console.WriteLine(n + " rows Updated");
                }
                else
                {
                    Console.WriteLine("Unable to Update the rows");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
        public void UpdateCity(string id, string city)
        {
            try
            {
                conn.Open();
                string str = $"Update Student set City = '{city}'where id='{id}'";
                SqlCommand cmd = new SqlCommand(str, conn);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    Console.WriteLine(n + " rows Updated");
                }
                else
                {
                    Console.WriteLine("Unable to Update the rows");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
        public void Delete(string id)
        {
            try
            {
                conn.Open();
                string str = $"Delete from  Student where Id='{id}'";
                SqlCommand cmd = new SqlCommand(str, conn);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    Console.WriteLine(n + " rows Deleted");
                }
                else
                {
                    Console.WriteLine("Unable to Delete the rows");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
        public void DisplayAll()
        {
            SqlDataReader rdr = null;
            try
            {
              
                conn.Open();
                string str = "Select * from Student";
                SqlCommand cmd = new SqlCommand(str, conn);
                rdr = cmd.ExecuteReader();
                Console.WriteLine("Id Name Age Standard City");
                while (rdr.Read())
                {
                    for (int i = 0; i < rdr.FieldCount; i++)
                    {
                        Console.Write(rdr[i] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("*********************************");
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                if(rdr != null)
                {
                    rdr.Close();
                }
            }

        }






    }
}
