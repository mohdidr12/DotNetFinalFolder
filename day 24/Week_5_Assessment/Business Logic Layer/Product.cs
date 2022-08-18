using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Assessment
{
    class Product
    {
        int p_id, cp_id;
        double price;
        string p_name;
        public int P_Id   // property
        {
            get { return p_id; }   // get method
            set { p_id = value; }  // set method
        }
        public int Cp_Id   // property
        {
            get { return cp_id; }   // get method
            set { cp_id = value; }  // set method
        }
        public double Price   // property
        {
            get { return price; }   // get method
            set { price = value; }  // set method
        }


        public string P_Name   // property
        {
            get { return p_name; }   // get method
            set { p_name = value; }  // set method
        }
    }

}
