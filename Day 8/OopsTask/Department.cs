using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsTask
{
    class Department : HRManagement
    {
        public void Location()
        {
            
            Console.WriteLine("What is the Location?");
            string str = Console.ReadLine();
            Console.WriteLine("location is" + str);

        }
        public void SetWork()
        {
            
            Console.WriteLine("name of Employee which the project has to given");
            String ename = Console.ReadLine();
            Console.WriteLine("Project is assign to "+ename);
         

        }
    }
}
