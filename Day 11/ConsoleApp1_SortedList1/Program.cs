using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1_SortedList1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating
            SortedList list = new SortedList();
            SortedList<string, string> phoneBook = new SortedList<string, string>();

            //Adding
            phoneBook.Add("Jack", "82323349");
            phoneBook.Add("Willy", "944556789");
            phoneBook.Add("Charles", "1233434343");
            phoneBook.Add("Jame", "3434343444");

            //Displaying
            foreach (var item in phoneBook)
            {
                Console.WriteLine(item.Key + " the mobile no. is " + item.Value);
            }
            //Index 
            phoneBook["Jack"] = "1234567345";
            Console.WriteLine(phoneBook["Jack"]);
            //Try get value
            phoneBook.TryGetValue("james", out string number);
            Console.WriteLine(number);
            //Remove
            Console.WriteLine("----------");
            Console.WriteLine("After removing");
            phoneBook.Remove("Willy");
            phoneBook.RemoveAt(1);
            foreach(var item in phoneBook)
            {
                Console.WriteLine(item.Key);

            }
            //Remove all
            Console.WriteLine(phoneBook.Count);
            //phoneBook.Clear();
            //Console.WriteLine(phoneBook.Count);

            //Contain
            Console.WriteLine(phoneBook.ContainsValue("01010103232"));
            Console.ReadLine();
        }
    }
}
