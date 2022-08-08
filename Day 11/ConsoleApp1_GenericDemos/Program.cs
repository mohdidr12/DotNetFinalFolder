using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1_GenericDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstlist = new List<string>()
            {
                "Australia", "Belgium","Brazil"
            };
            firstlist.Add("Russia");
            List<string> secondlist = new List<string>();
            //Adding

            firstlist.Add("INDIA");
            firstlist.Add("England");
            firstlist.Add("Hungary");
            firstlist.Add("Egypt");
            Console.WriteLine("---------------"); 
                
                
                //Displaying
            foreach(var item in firstlist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------");

            //Count
            Console.WriteLine("Count=  " + firstlist.Count);
            Console.WriteLine("---------------");
           
            
            //Index
            firstlist[3] = "south Korea";
            Console.WriteLine(firstlist[3]);
            foreach (var item in firstlist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------");

            //Sorting
            Console.WriteLine("After sorting");
            firstlist.Sort();
            foreach (var item in firstlist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------");

            //Count
            Console.WriteLine("Count=  " + firstlist.Count);
            Console.WriteLine("---------------");

            //Reversing
            Console.WriteLine("After reversing");
            firstlist.Reverse();
            foreach (var item in firstlist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------");


            //Removing
            Console.WriteLine("After removing...");
            firstlist.Remove("Germany");
            firstlist.RemoveAt(0);
            foreach (var item in firstlist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------");
            //Count
            Console.WriteLine("Count=  " + firstlist.Count);
            Console.WriteLine("---------------");

            //Remove all
            //firstlist.Clear();

            //Contains
            Console.WriteLine(firstlist.Contains("Egypt"));

            //Get RAnge

            secondlist = firstlist.GetRange(0, 3);
            Console.WriteLine("Now we are in the second List");
            foreach (var item in secondlist)

            {
                Console.WriteLine(item);
            }
           // Console.ReadLine();





            Console.ReadLine();


        }
    }
}
