using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Department d1 = new Department();
            Console.WriteLine("work of HR Management");
            e1.Manage();
            Console.WriteLine("Now Department has to Assign Work to Employees");
            d1.Location();
            d1.SetWork();
            Console.WriteLine("work Done By Employees");
            e1.Work();
            e1.ShowWork();
        }
    }
}
