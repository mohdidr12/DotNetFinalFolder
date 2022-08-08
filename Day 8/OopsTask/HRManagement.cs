using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsTask
{
    class HRManagement
    {
        public virtual void  Manage()
        {
            Console.WriteLine("I am Managing");
            Console.WriteLine("************************************************");
            Console.WriteLine("name of The Project Which the work has done");
            string prj = Console.ReadLine();
            Console.WriteLine("Which Technology used in Project?");
             string ework = Console.ReadLine();
            Console.WriteLine("Project Assign on " + ework);
           
        }
      
    }
}
