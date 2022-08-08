using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTask
{  
    class TaskEvent
    {
        public delegate void printDelegate();
        public event printDelegate message;
        public  void printname(string str)
        {
            if (str == "Ram" || str == "Sham" || str == "Naveen")
            {
                message();
            }
            else
            {
                Console.WriteLine("Welcome " + str);
            }
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your name");
            string str = Console.ReadLine();
            TaskEvent t1 = new TaskEvent();
            t1.message += new TaskEvent.printDelegate(EventMessage);
            t1.printname(str);
        }
            static void EventMessage()
            {
                Console.WriteLine("Event is Executed this person is block for organization");
                Console.WriteLine("sends an Email to Administrator");
            }
    }
}
