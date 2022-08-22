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
           
            finally
                {
                conn.Close();
                }
        }
        public DataTable GetAllBooks()
        {
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("GetBooks", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet dt = new DataSet();
                da.Fill(dt);
                return dt.Tables[0];

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
          
            finally
            {
                conn.Close();
            }

        }
        public bool UpdateBook(int _bookid, string _bookname)
        {
            try
            {
                conn.Open();
                SqlCommand da = new SqlCommand("UpdateDemo", conn);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@BookId", _bookid);
                da.Parameters.AddWithValue("@BookName", _bookname);
                da.ExecuteNonQuery();
                return true;

            }
           
            finally
            {
                conn.Close();
            }

        }

    }
  }
