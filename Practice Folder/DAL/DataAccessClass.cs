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


        public bool Add(int _id, string _name, int _std)
        {
            try
            {
                conn.Open();
                string str = $"Insert into StudentTable Values('{_id}','{_name}','{_std}')";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.ExecuteNonQuery();
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
