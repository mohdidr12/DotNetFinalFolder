using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Week_5_Assessment
{
   public  class ConnectionClass
    {
        SqlConnection conn;
        public ConnectionClass()
        {
            conn = new SqlConnection("Server = DEL1-LHP-N82101; Database = AssessmentDb; Integrated Security = SSPI");

        }
        public bool AddCategory(int c_id, string c_name)
        {
            try
            {
                conn.Open();
                string str = $"Insert into Category values('{c_id}','{c_name}')";
                SqlCommand cmd = new SqlCommand(str, conn);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    Console.WriteLine(n + " rows Inserted");
                    return true;
                }
                else
                {
                    Console.WriteLine("Unable to insert the rows");
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public bool DisplayAllCategory()
        {
            SqlDataReader rdr = null;
            try
            {

                conn.Open();
                string str = "Select * from Category";
                SqlCommand cmd = new SqlCommand(str, conn);
                rdr = cmd.ExecuteReader();
                Console.WriteLine("CId Name");
                while (rdr.Read())
                {
                    for (int i = 0; i < rdr.FieldCount; i++)
                    {
                        Console.Write(rdr[i] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("*********************************");
                    return true;
                }
                return false;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
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
        public bool AddProduct(int p_id, string p_name, double price, int cp_id)
        {
            try
            {
                conn.Open();
                string str = $"Insert into Product values('{p_id}','{p_name}','{price}','{cp_id}')";
                SqlCommand cmd = new SqlCommand(str, conn);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    Console.WriteLine(n + " rows Inserted");
                    return true;
                }
                else
                {
                    Console.WriteLine("Unable to insert the rows");
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public bool DisplayAllProducts()
        {
            SqlDataReader rdr = null;
            try
            {

                conn.Open();
                string str = "Select * from Product";
                SqlCommand cmd = new SqlCommand(str, conn);
                rdr = cmd.ExecuteReader();
                Console.WriteLine("PId Name Price CId");
                while (rdr.Read())
                {
                    for (int i = 0; i < rdr.FieldCount; i++)
                    {
                        Console.Write(rdr[i] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("*********************************");
                    return true;
                }
                return false;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
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
        public bool SearchProduct(int p_id)
        {
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                string str = $"Select * from Product where ProductId='{p_id}'";
                SqlCommand cmd = new SqlCommand(str, conn);
                rdr = cmd.ExecuteReader();
                Console.WriteLine("PId Name Price CId");
                while (rdr.Read())
                {
                    for (int i = 0; i < rdr.FieldCount; i++)
                    {
                        Console.Write(rdr[i] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("*********************************");
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
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
        public bool UpdateProductPrice(double price, int p_id)
        {
            try
            {
                conn.Open();
                string str = $"Update Product set Price='{price}' where ProductId='{p_id}'";
                SqlCommand cmd = new SqlCommand(str, conn);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    Console.WriteLine(n + " rows Updated");
                    return true;
                }
                else
                {
                    Console.WriteLine("Unable to Update the rows");
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public bool DeleteProduct(int p_id)
        {
            try
            {
                conn.Open();
                string str = $"Delete from Product where ProductId='{p_id}'";
                SqlCommand cmd = new SqlCommand(str, conn);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    Console.WriteLine(n + " rows Deleted");
                    return true;
                }
                else
                {
                    Console.WriteLine("Unable to Delete the rows");
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
        public void DisplayProductWithCategories()
        {
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                string str = $"Select Product.ProductId,Product.ProductName,Product.Price,Category.CategoryId,Category.CategoryName from Category join Product on Category.CategoryId=Product.CategoryId";
                SqlCommand cmd = new SqlCommand(str, conn);
                rdr = cmd.ExecuteReader();
                Console.WriteLine("PId PName Price CId CName");
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
    }
}
