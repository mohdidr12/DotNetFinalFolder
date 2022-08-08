using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Delegate2
{
    public delegate void Print(int value);
    class Program
    {
        public static void PrintHelperMethod(Print printdl,int val)
        {
            val += 10;
            printdl(val);
        }
            static void Main(string[] args)
        {
            PrintHelperMethod (delegate (int val) 
                            { 
                             Console.WriteLine("Anonymous method: {0}", val); 
                             }
                               , 100);
        }
    }
}
