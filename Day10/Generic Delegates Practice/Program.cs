using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Delegates_Practice
{
    class Program
    {
        public static  void printHello(String str)
        {
            Console.WriteLine("hellooo "+str);
        }
        public static double area(float a, float b)
        {
            return a * b;
        }
        public static  bool CheckCond(int n)
        {
            return n > 10;
        }
        static void Main(string[] args)
        {
            Func<float, float, double> m1 = area;
            double db=m1.Invoke(3.4f, 7.8f);
            Console.WriteLine(db);
            Action<string> m2 = printHello;
            m2.Invoke("idris");
            Predicate<int> m3 = CheckCond;
            Boolean res =m3.Invoke(1);
            Console.WriteLine(res);
        }
    }
}
