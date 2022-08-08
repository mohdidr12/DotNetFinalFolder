using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> s1 = new SortedDictionary<int, string>();
            s1.Add(1, "huzaifa");
            s1.Add(2, "balot");
            s1.Add(3, "zainab");
            s1.Add(4, "yusuf");

            foreach(KeyValuePair<int, string> kv in s1)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }
    }
}




       
