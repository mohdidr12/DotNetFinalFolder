using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameterDemo
{
    class Program
    {
      
        static void Main(string[] args)
        {
            //calling the static method with named
            //parameters without any order
            addstr1(s2: "is for ", s1: "Shardha.k ", s3: ".Net Training");
        }
        public static void addstr1(string s1,string s2,string s3)
        {
            string result = s1 + s2 + s3;
            Console.WriteLine("Final string is: " + result);
            Console.ReadLine();
        }
    }
}
