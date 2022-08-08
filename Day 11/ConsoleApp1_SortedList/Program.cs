using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedlist = new SortedList();
            //Adding
            sortedlist.Add(1, "Jan");
            sortedlist.Add(2, "Feb");
            sortedlist.Add(3, "Mar");
            sortedlist.Add(4, "Apr");
            sortedlist.Add(5, "May");
            //Displaying
            //Foreach

            foreach(DictionaryEntry item in sortedlist)
            {
                Console.WriteLine(item.Key + ":  " + item.Value);

            }
            //for
            Console.WriteLine("--------------------------");
            for (int i = 0; i < sortedlist.Count;i++)
            {
                Console.WriteLine(sortedlist.GetKey(i) + ":  " + sortedlist.GetByIndex(i));
            }

            Console.WriteLine("--------------------------");
            //Index
            Console.WriteLine(sortedlist[5].ToString());

            Console.WriteLine("--------------------------");

            //capacity

            Console.WriteLine(sortedlist.Count);

            Console.WriteLine("--------------------------");

            //Remove
            sortedlist.Remove(1);
            foreach(DictionaryEntry item in sortedlist)
            {
                Console.WriteLine(item.Key + ":  " + item.Value);
            }
            Console.WriteLine("--------------------------");
            //Contain

            Console.WriteLine(sortedlist.ContainsValue("Apr"));
            Console.WriteLine("--------------------------");
            //Copy to Arraylist

            Console.WriteLine("Now we are inside the array list");
            ArrayList array = new ArrayList(sortedlist.Values);
            foreach(var item in array)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
