using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_EVENTS
{
    class Program
    {
        
        static void Main(string[] args)
        {
            AddTwoNumber a = new AddTwoNumber();
            a.ev_OddNumber += new AddTwoNumber.dg_OddNumber(EventMessage);
            a.Add();
            Console.ReadLine();
        }
        static void EventMessage()
        {
            Console.WriteLine("event executed :This is odd number");
        }
    }
    //This is publisher Class
    class AddTwoNumber
    {
        public delegate void dg_OddNumber();
        public event dg_OddNumber ev_OddNumber;
        public void Add()
        {
            int result;
            result = 5 + 4;
            Console.WriteLine(result.ToString());
            if((result%2!=0)&&(ev_OddNumber!=null))
            {
                ev_OddNumber();
            }
        }
    }
}
