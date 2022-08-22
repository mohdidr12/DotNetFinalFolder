using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
   
    public class DataAccessClass
    {
        SqlConnection conn;
        public DataAccessClass()
        {
            conn = new SqlConnection("Server = DEL1-LHP-N82101\\MSSQLSERVER01; Database = demo_1; Integrated Security = SSPI");
        }
        public bool Insert(int _bookid , string _bookname,string _author,string _publisher,double _price)
        {
            try
            {
                conn.Open();
                SqlCommand  da = new SqlCommand("InsertBooks", conn);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@BookId", _bookid);
                da.Parameters.AddWithValue("@BookName",_bookname);
                da.Parameters.AddWithValue("@Author", _author);
                da.Parameters.AddWithValue("@Publisher", _publisher);
                da.Parameters.AddWithValue("@Price", _price);
                da.ExecuteNonQuery();
                return true;

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
                {
                conn.Close();
                }
        }
        public bool GetAllBooks()
        {
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("GetBooks", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
               
                DataTable dt = new DataTable();
                da.Fill(dt);
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool DeleteBooks(int _bookid)
        {
            try
            {
                conn.Open();
                SqlCommand da = new SqlCommand("DeleteBooks", conn);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@BookId", _bookid);
                da.ExecuteNonQuery();
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }

        }
        public bool UpdateBook(int _bookid, string _bookname, double _price)
        {
            try
            {
                conn.Open();
                SqlCommand da = new SqlCommand("UpdateBook", conn);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@BookId", _bookid);
                da.Parameters.AddWithValue("@BookName", _bookname);
                da.Parameters.AddWithValue("@Price", _price);
                da.ExecuteNonQuery();
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }

        }

    }
  }
