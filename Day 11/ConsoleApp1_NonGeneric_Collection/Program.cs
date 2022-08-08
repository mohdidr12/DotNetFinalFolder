using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1_NonGeneric_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList ();
            array.Add("James");
            array.Add("David");
            array.Add("Charles");
            array.Add("Ahamad");
           // array.Add(1);
            Console.WriteLine("At first");
            foreach(var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------");
            Console.WriteLine("Before insertion");
            Console.WriteLine("Count is  " + array.Count);
            array.Insert(2, "Tim");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After insertion");
            Console.WriteLine("Count is  " + array.Count);
            Console.WriteLine("----------------------");
            array.Sort();
            Console.WriteLine("After sorting");
            foreach(var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------");
            array.Reverse();
            Console.WriteLine("After reversing");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------");
            Console.WriteLine("After Removing");
            array.Remove("James");
            array.RemoveAt(2);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine("Remove all");
            //array.Clear();
            Console.WriteLine("-------------");
            array.RemoveRange(1, 2);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------");
            Console.WriteLine("After asking if contains");
            Console.WriteLine(array.Contains("James"));
        
            Console.WriteLine("----------");
            ArrayList names = new ArrayList();
            
            names = array.GetRange(0, 1);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
