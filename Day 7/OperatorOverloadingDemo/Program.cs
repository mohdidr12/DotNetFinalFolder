using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingDemo
{
    class Abc
    {
        public int number1, number2;
        public Abc(int num1, int num2)
        {
            number1 = num1;
            number2 = num2;
        }
        public static Abc operator -(Abc c1)
        {
            c1.number1 = -c1.number1;
            c1.number2 = -c1.number2;
            return c1;
        }
        public void Print()
        {
            Console.WriteLine("Number1 = " + number1);
            Console.WriteLine("Number2 = " + number2);
        }
    }
 class Program { 
            static void Main(string[] args)
        {
               Abc calc = new Abc(30, -20);
            calc = -calc;
            calc.Print();
            Abc calc1 = new Abc(-45, 15);
            calc1 = -calc1;   
            calc1.Print();
    }
    }
}
