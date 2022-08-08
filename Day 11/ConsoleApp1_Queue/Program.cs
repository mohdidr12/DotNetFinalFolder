using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating
            Queue que = new Queue();
            //Adding
            que.Enqueue("David");
            que.Enqueue("James");
            que.Enqueue("Charles");
            que.Enqueue("tim");
            que.Enqueue(1);

            //Displying
            foreach(var item in que)
            {
                Console.WriteLine(item);
            }

            //Contains
            Console.WriteLine("------------");
            Console.WriteLine(que.Contains("James"));


            //Counting
            Console.WriteLine("------------");
            Console.WriteLine(que.Count);

            //Removing
            Console.WriteLine("------------");
            Console.WriteLine(que.Dequeue());
            Console.WriteLine(que.Dequeue());
            Console.WriteLine(que.Dequeue());

            //Displaying
            Console.WriteLine("------------");
            foreach(var item in que )
            {
                Console.WriteLine(item);
            }

            //Again count
            Console.WriteLine("------------");
            Console.WriteLine(que.Count);

            //peek 
            Console.WriteLine("------------");
            Console.WriteLine(que.Peek());


            Console.ReadLine();
        }
    }
}
