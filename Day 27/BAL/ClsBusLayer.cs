using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Layer;

namespace BAL
{
   public class ClsBusLayer
    {
      public ClsDataLayer  obj = new ClsDataLayer();
        public void InsertNewUser(string _name,string _add,string _city,string _email)
        {
            obj.InsertData(_name, _add, _city, _email);
        }
        public object SelectUser()
        {
            return obj.selectData();
        }
        
    }



    
}
