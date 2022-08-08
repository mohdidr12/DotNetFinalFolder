using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicParamDemo
{
    class Program
    {
        public static void mulval(dynamic val)
        {
            val *= val;
            Console.WriteLine(val);
        }
        static void Main(string[] args)
        {
            mulval(30);
        }
    }
}
