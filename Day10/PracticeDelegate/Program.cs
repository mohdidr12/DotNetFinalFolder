using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDelegate
{
    public delegate void addDelegate(int a, int b);
    public delegate string printDelegate(string str);
    class Program
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static string printName(string str)
        {
            return "my name is " + str;
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            addDelegate d1 = p1.add;
            d1.Invoke(3, 4);
            printDelegate p2 = Program.printName;
            string name = p2.Invoke("idris");
            Console.WriteLine(name);
        }
    }
}
