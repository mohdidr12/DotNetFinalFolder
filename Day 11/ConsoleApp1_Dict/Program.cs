using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1_Dict
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> capitals = new Dictionary<string, string>();
            //Add
            capitals.Add("India", "Delhi");
            capitals.Add("Russia", "moscow");
            capitals.Add("Italy", "Rome");
            capitals.Add("Spain", "Marid");
            capitals.Add("Germany", "Berline");
            capitals.Add("England", "London");

            //Displaying

            foreach(var item in capitals)
            {
                Console.WriteLine(item.Key);

            }
            foreach(KeyValuePair<string,string> item in capitals)
            { }
            Console.WriteLine("====================");
            foreach(var item in capitals)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine("====================");

            //Creating with initialization

            Dictionary<int, string> names = new Dictionary<int, string>()
            {
                {1,"james" },
                {2,"Jack" },
                {3,"Emma" },
            };
            foreach(var item in names)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            Console.WriteLine("====================");
            //Index

            Console.WriteLine("-----------------");
            capitals["Italy"] = "Venice";
            capitals["Brazil"] = "Rio di genero";
            Console.WriteLine(capitals["Italy"]);
            Console.WriteLine(capitals["Brazil"]);
            Console.WriteLine("====================");

            //Try get value
            capitals.TryGetValue("Russia", out string result);
            if (result != null)
                Console.WriteLine("Result is  " + result);
            Console.WriteLine("====================");
            //Remove
            capitals.Remove("Italy");
            Console.WriteLine("-----------------");
            Console.WriteLine("After Removing");
            foreach(var item in capitals)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }
            Console.WriteLine(capitals.Count);
            Console.WriteLine("====================");
            //Remove all
            //capitals.Clear();
            Console.WriteLine(capitals.Count);
            Console.WriteLine("====================");

            //Contain
            Console.WriteLine(capitals.ContainsKey("France"));
            Console.ReadLine();
        }
    }
}
