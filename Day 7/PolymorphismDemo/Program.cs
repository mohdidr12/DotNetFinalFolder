using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    class Program
    {
        
        public Program()
        {
            Console.WriteLine("i am a default constructor");
        }
        public Program(double l,double w)
        {
            Console.WriteLine("Area of Rectangle "+(l*w));
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter length");
            double length = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter width");
            double width = Double.Parse(Console.ReadLine());
            Program m1 = new Program();
            Program m2 = new Program(length, width);
        }
    }
}
