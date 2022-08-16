using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredPracticeTwoTable
{
    class Course
    {
        int c_id;
        string c_name;
        public int C_Id   // property
        {
            get { return c_id; }   // get method
            set { c_id = value; }  // set method
        }
        public string C_Name
        {
            get { return c_name; }   // get method
            set { c_name = value; }  // set method
        }
    }
}
