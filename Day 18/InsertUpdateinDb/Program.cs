using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace InsertUpdateinDb
{
  
    class Program
    {
        SqlConnection conn;
        public Program()
        {
            conn = new SqlConnection("Data Source=DEL1-LHP-N82101\\MSSQLSERVER01;Initial Catalog=Northwind;Integrated Security=SSPI");

        }
        static void Main(string[] args)
        {
            Program scd = new Program();

            Console.WriteLine();
            Console.WriteLine("Categories before Insert");
            Console.WriteLine("-----------------------------------");
            //use Execute Reader method
            scd.ReadData();
            Console.ReadLine();

            //use ExecuteNonQuery method for Insert
            scd.Insertdata();
            Console.WriteLine("Categories After Insert");
            Console.WriteLine("-----------------------------------");


            //Execute Non Query method for update
            scd.UpdateData();

            Console.WriteLine();
            Console.WriteLine("Categories After Update");
            Console.WriteLine("-----------------------------------");

            scd.ReadData();
            Console.ReadLine();
            //use ExecuteNonQuery method for Delete
            scd.DeleteData();

            Console.WriteLine();
            Console.WriteLine("categories After Delete");
            Console.WriteLine("-----------------------------------");
            Console.ReadLine();

            scd.ReadData();
            Console.ReadLine();
            //use ExecuteScaler method
            int numberOfRecords = scd.GetNumberOfRecords();

            Console.WriteLine();
            Console.WriteLine("Number of Records:{0}", numberOfRecords);
            Console.ReadLine();
        }
        public void ReadData()
        {
            SqlDataReader rdr = null;
            try
            {
                //open the connection
                conn.Open();
                //1. Instatntiate a new command with a query and connection
                SqlCommand cmd = new SqlCommand("Select CategoryName from Categories", conn);
                //2. Call execute reader to get query results
                rdr = cmd.ExecuteReader();
                //print the category Name of each record
                while(rdr.Read())
                {
                    Console.WriteLine(rdr[0]);
                }
            }
            finally
            {
                //close the reader
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
        public void Insertdata()
        {
            try
            {
                //Open the connection
                conn.Open();
                //prepare command string
                string InsertString = @"insert into Categories(CategoryName,Description)
                                   values('Miscellaneous','whatever doesnt fit elsewhere')";

                //1. Instantiate a new command with a query and connection
                SqlCommand cmd = new SqlCommand(InsertString, conn);
                //2. Call EecuteQuery to send command
                cmd.ExecuteNonQuery();
            }
            finally
            {
                //Close the connection
                if(conn!=null)
                {
                    conn.Close();
                }
            }
            }
         public void UpdateData()
        {
            try
            {
                //Open the connection
                conn.Open();

                //prepare command string
                string updateString = @"update Categories set CategoryName='Other' where CategoryName='Miscellaneous'";
                //1. Instantiate a new command with command text only
                SqlCommand cmd = new SqlCommand(updateString);
                //2. Set the Connection property
                cmd.Connection = conn;
                //3. call executeNonQuery to send command
                cmd.ExecuteNonQuery();
            }
            finally
            {
                //Close the connection
                if(conn!=null)
                {
                    conn.Close();
                }
            }
        }
        public void DeleteData()
        {
            try
            {
                //Open the connection
                conn.Open();

                //prepare command string
                string deleteString = @"delete from Categories where CategoryName='Other'";
                //1. Instantiate a new command
                SqlCommand cmd = new SqlCommand();
                //2 . Set the Command Text property
                cmd.CommandText = deleteString;
                //3. Set the Connetion property
                cmd.Connection = conn;
                //4. call ExecuteNonQuery to send command
                cmd.ExecuteNonQuery();
            }
            finally
            {
                //close the connection
                if(conn!=null)
                {
                    conn.Close();
                }
            }
        }
        public int GetNumberOfRecords()
        {
            int count = -1;
            try
            {
                //open connection
                conn.Open();
                //1. Instantiate a new command 
                SqlCommand cmd = new SqlCommand("Select count(*) from Categories", conn);
                //2. call executeScalar to send command
                count = (int)cmd.ExecuteScalar();
            }
            finally
            {
                //close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return count;
        }
        }
}

      