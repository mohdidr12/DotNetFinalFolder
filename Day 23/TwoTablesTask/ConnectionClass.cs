using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TwoTablesPractice
{
    class ConnectionClass : IStudent,ICourse
    {
        SqlConnection conn;
        public ConnectionClass()
        {
            conn = new SqlConnection("Server = DEL1-LHP-N82101; Database = SchoolsDb; Integrated Security = SSPI");
        }
        public void AddStudent(int id, string name, byte age, byte standard, string city)
        {
            try
            {
                conn.Open();
                string str = $"Insert into StudentDemo values('{id}','{name}','{age}','{standard}','{city}')";
                SqlCommand cmd = new SqlCommand(str, conn);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    Console.WriteLine(n + " rows Inserted");
                }
                else
                {
                    Console.WriteLine("Unable to insert the rows");
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
        public void UpdateAge(int id, byte age)
        {
            try
            {
                conn.Open();
                string str = $"Update StudentDemo set Age = '{age}'where St_id='{id}'";
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
        public void UpdateCity(int id, string city)
        {
            try
            {
                conn.Open();
                string str = $"Update StudentDemo set City = '{city}'where St_id='{id}'";
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
        public void DeleteStudent(int id)
        {
            try
            {
                conn.Open();
                string str = $"Delete from  StudentDemo where St_Id='{id}'";
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
                string str = "Select * from StudentDemo";
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
                if (rdr != null)
                {
                    rdr.Close();
                }
            }

        }
        public void AddCourse(int id,int c_id,string c_name)
        {
            try
            {
                conn.Open();
                string str = $"Insert into CourseDemo values('{id}','{c_id}','{c_name}')";
                SqlCommand cmd = new SqlCommand(str, conn);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    Console.WriteLine(n + " rows Inserted");
                }
                else
                {
                    Console.WriteLine("Unable to insert the rows");
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
        public void UpdateCourse(int c_id,string c_name)
        {
            try
            {
                conn.Open();
                string str = $"Update CourseDemo set C_Name='{c_name}'where C_Id='{c_id}'";
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
        public void DeleteCourse(int c_id)
        {
            try
            {
                conn.Open();
                string str = $"Delete from CourseDemo where C_id = '{c_id}'";
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
        public void DisplayCourse()
        {
            SqlDataReader rdr = null;
            try
            {

                conn.Open();
                string str = "Select * from CourseDemo";
                SqlCommand cmd = new SqlCommand(str, conn);
                rdr = cmd.ExecuteReader();
                Console.WriteLine("St_Id  C_Id  C_Name ");
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
                if (rdr != null)
                {
                    rdr.Close();
                }
            }

        }
        public void DisplayEnrollStudent()
        {
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                string str = $"Select StudentDemo.St_id ,StudentDemo.Name,CourseDemo.C_Id,CourseDemo.C_Name from StudentDemo join CourseDemo on StudentDemo.St_id=CourseDemo.St_id ";
                SqlCommand cmd = new SqlCommand(str, conn);
                rdr = cmd.ExecuteReader();
                Console.WriteLine("St_Id  Name  C_id   C_Name ");
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
                if (rdr != null)
                {
                    rdr.Close();
                }
            }

        }
        public void CountOfStudents()
        {
            try
            {
                conn.Open();
                string str = "Select count(*) from StudentDemo";
                SqlCommand cmd = new SqlCommand(str, conn);
                int count = (int)cmd.ExecuteScalar();
                if(count>0)
                {
                    Console.WriteLine("Total No of Students "+ count);
                }
                else
                {
                    Console.WriteLine("No Students here to Display . Please Add Some");
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
        public void CountOfCourse()
        {
            try
            {
                conn.Open();
                string str = "Select count(*) from CourseDemo";
                SqlCommand cmd = new SqlCommand(str, conn);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    Console.WriteLine("Total Courses are "+count);
                }
                else
                {
                    Console.WriteLine("No Course here to Display . Please Add Some");
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
     }
}
      

