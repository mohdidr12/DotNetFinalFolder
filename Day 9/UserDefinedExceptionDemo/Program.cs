using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedExceptionDemo
{
    class AgeException : Exception 
    {
        public AgeException(string str) : base(str)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Registration form");
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Age");
            int age = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (age < 18)
                {
                    throw new AgeException("Age cannot be less than 18");
                }
                else
                {
                    Console.WriteLine("Registration done successfully");
                }
            }
            catch(AgeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
    }
}
