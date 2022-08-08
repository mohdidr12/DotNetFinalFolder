using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyGeekDemo
{
    class Program
    {
        readonly int i ;
        readonly string name;
        Program(int j, string str)
        {
            i = j;
            name = str;
        }
        public void print()
        {
            Console.WriteLine("name is " + name);
            Console.WriteLine("value of i " + i);
        }

        static void Main(string[] args)
        {
            Program p = new Program(89,"Idris");
            p.print();
        }
    }
}
