using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL_Layer
{
    public class ClsDataLayer
    {
        DataSet1.User_SelectDataTable userDT = new DataSet1.User_SelectDataTable();
        DataSet1TableAdapters.User_SelectTableAdapter userDA = new DataSet1TableAdapters.User_SelectTableAdapter();
        public void InsertData(string _name,string _address,string _city , string _email)
        {
            int i = userDA.Insert(_name, _address, _city, _email);
        }
        public object selectData()
        {
            return userDT = userDA.GetData();
        }
    }
}
