using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class XYZ:Iwork
    {
        public void Add()
        {
            Console.WriteLine("I am from XYZ class");
        }
        public int Calc()
        {
            int count = 5;
            return count;
        }
    }
}
