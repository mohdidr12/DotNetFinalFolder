using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Gemeric_delegate
{
    class Myclass
    {
        public static bool IsDate(string date)
        {
            DateTime dt;
            return DateTime.TryParse(date, out dt);
        }
        public static int Multi (int a , int b)
        { 
            return a + b;
        }
        public static void sum(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
        }
        public static void add(string fname,string lname)
        {
            string fullname = fname + " " + lname;
        }
        class Program
        {
            static void Main(string[] args)
            {
                //action delegate
                Action<int, int> a = new Action<int, int>(Myclass.sum);
                a(15, 16);
                Action<string, string> b = new Action<string, string>(Myclass.add);
                b("sharda", "Banglore");
                //Func Delegate

                Func<int, int, int> ds = new Func<int, int, int>(Myclass.Multi);
                Console.WriteLine(ds(45, 65));
                //Predicate Delicate
                Predicate<string> p = new Predicate<string>(Myclass.IsDate);
                if (p("18-05-2022"))
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
                Console.ReadLine();
            }
        }
    }
}
