using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> l1 = new LinkedList<string>();
            l1.AddLast("huzaifa");
            l1.AddLast("umar");
            l1.AddLast("idris");
            l1.AddLast("sonu");
           // l1.AddFirst("adil");
            l1.AddLast("Rishabh");
            LinkedListNode<string> node = l1.Find("umar");
            l1.AddBefore(node, "Rizwan");
            l1.AddAfter(node, "osman");
            foreach(string s in l1)
            {
                Console.WriteLine(s);
            }


        }
            

    }
}
