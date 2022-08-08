using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedDemo
{
    sealed class ClassDemo
    {
        public void Add()
        {
            Console.WriteLine("I am from Sealed class");
        }
    }
    class B 
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassDemo obj = new ClassDemo();
            obj.Add();
        }
    }
}
