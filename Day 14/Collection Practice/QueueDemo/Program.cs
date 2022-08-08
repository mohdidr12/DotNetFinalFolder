using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> q1 = new Queue<string>();
            q1.Enqueue("adil");
            q1.Enqueue("huzaifa");
            q1.Enqueue("salik");
            q1.Enqueue("sonu");
            q1.Enqueue("Amit");

            foreach(string s in q1)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("***********************************");
            Console.WriteLine(q1.Peek());
            Console.WriteLine("***********************************");
            string str=q1.Dequeue();
            Console.WriteLine("Deque element is "+str);
            Console.WriteLine("***********************************");
            Console.WriteLine(q1.Peek());



        }
    }
}
