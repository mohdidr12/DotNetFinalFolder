using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating 
            Stack stack = new Stack();
            //Adding
            stack.Push("David");
            stack.Push("Emmy");
            stack.Push("Jack");
            stack.Push("Emma");
            stack.Push(1);

            //Displaying
            foreach(var st in stack)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine("--------------");
            Console.WriteLine(stack.Peek());
            Console.WriteLine("Sequence of removing");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.ReadLine();
        }
    }
}
