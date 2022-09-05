using System;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Global logic";
            if(!name.Any(char.IsDigit))
            {
                Console.WriteLine(name + "-is in correct format");
            }
            else
            {
                throw new 
            }
            Console.WriteLine("Hello World!");
        }
    }
}
