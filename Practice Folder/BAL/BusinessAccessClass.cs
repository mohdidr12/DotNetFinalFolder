using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class BusinessAccessClass
    {
        DataAccessClass objdata = new DataAccessClass();
        public void InsertFun(int _id,string _name,int _std)
        {
            if(objdata.Add(_id,_name,_std))
            {
                Console.WriteLine("Students Added Successfully");
            }
            else
            {
                Console.WriteLine("Students Not Added Successfully");
            }

        }
    }
}
