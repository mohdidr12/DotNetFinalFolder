using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> s1 = new Stack<string>();
            s1.Push("huzaifa");
            s1.Push("Rauf");
            s1.Push("umar");
            s1.Push("adil");
            s1.Push("shahid");

            foreach(string s in s1)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("***********************");
            Console.WriteLine(s1.Peek());
            Console.WriteLine("***********************");
            string str = s1.Pop();
            Console.WriteLine("Pop element is " + str);
            Console.WriteLine("***********************");
            Console.WriteLine(s1.Peek());
        }
    }
}
