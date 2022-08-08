using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    class Program
    {
        enum Week
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        enum color
        {
            red=1,
            blue=3,
            yellow=5
        }
        enum Dept
        {
            csc=1,
            EC=2,
            EEE=3
        }
        static void Main(string[] args)
        {
            int a = (int)Week.Sunday;
            int b = (int)Week.Monday;
            int c = (int)Week.Tuesday;
            int d = (int)color.yellow;
            Console.WriteLine(Week.Sunday);
            Console.WriteLine(Week.Monday);
            Console.WriteLine("Sunday:{0} ", a);
            Console.WriteLine("Monday:{0} ", b);
            Console.WriteLine("Tuesday{0} ", c);
            Console.WriteLine("Yellow:{0} ", d);
            Console.WriteLine("\nPress Enter any Key to Exit...");
            
            Console.ReadLine();
        }
    }
}
