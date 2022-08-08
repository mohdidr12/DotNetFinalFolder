using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paramDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //  ParamsMethod(1, 2, "Nandini", "mrinali", "Shruthi", 10.26);
            ParamsMethod(1, 2,34,56,78,99,345);
        }
        public static void ParamsMethod(params int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i] + (i < arr.Length - 1 ? "," : ""));
            }
            Console.WriteLine();
            Console.WriteLine("\n Press Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
