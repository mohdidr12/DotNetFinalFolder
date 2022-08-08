using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassDemo
{
    class Program
    {
        public  int Instacalculation(int x,int y)
        {
            return x + y;
        }
        public static string Name;
        public static string FirstName;
        static Program()
        {
            Name = "Global logic training";
        }
        public static int calculation(int x,int y)
        {
            return x - y;
        }
        static void Main(string[] args)
        {
            Program x = new Program();
            int newval = x.Instacalculation(12, 12);
            Console.WriteLine(newval);
            Console.WriteLine( calculation(12, 12));

        }
    }
}
