using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_L;

namespace BAL_Layer
{
    public class BusinessLayerClass
    {
        DataLayerClass cs = new DataLayerClass();
        public void InsertNewUser(string _name, string _add, string _city, string _email)
        {
            cs.InsertData(_name, _add, _city, _email);
        }
        public object SelectUser()
        {
            return cs.SelectData();
        }
    }
}
