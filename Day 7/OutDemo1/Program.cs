using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 60;
            int b = 30;
            int p = 0;
            int q = 0;
            Calc(a, b, ref p, ref q);
            Console.WriteLine("Divisor is:{0} remainder is:{1}", p, q);
        }
        static void Calc(int x,int y,ref int Divider,ref int remainder)
        {
            Divider = x / y;
            remainder = x % y;
        }
    }
}
