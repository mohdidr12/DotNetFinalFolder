using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyFunctionOneDelegate
{
    public delegate void AddMul(int a, int b);
    class Program
    {
        public static void  Add(int a,int b)
        {
            Console.WriteLine("Addition is "+(a + b));
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine("Multiplication is "+(a * b));
        }
        static void Main(string[] args)
        {
            AddMul m1 = Add;
            m1 += Mul;
            m1.Invoke(3, 4);
        }
    }
}
