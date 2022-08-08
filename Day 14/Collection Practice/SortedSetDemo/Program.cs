using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> s1 = new SortedSet<string>() { "shanu", "devil", "zubair", "huzaifa", "babuu", "zubair" };
            

            foreach (string s in s1)
            {
                Console.WriteLine(s);
            }

        }
    }
}
