using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyDemo
{
    class Abc
    {
        public readonly string name = "Shardha";
        public readonly string location;
        public readonly int age;
        public Abc()
        {
            location = "Bangalore";
            age = 23;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Abc a1 = new Abc();
            //u.name="Rohini Ranger";
            Console.WriteLine("Name:{0}", a1.name);
            Console.WriteLine("Location:{0}",a1.location);
            Console.WriteLine("Age:{0}", a1.age);
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();

        }
    }
}
