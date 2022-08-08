using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceDemo
{
    interface IACT
    {
        void Network();
    }
    interface IGlobal
    {
        void Network();
    }
    class ABC : IACT, IGlobal
    {
        public void Network()
        {
            Console.WriteLine("I am from class Abc");
        }
        void IACT.Network()
        {
            Console.WriteLine("i am from IACT");
        }
        void IGlobal.Network()
            {

            Console.WriteLine("i am from IGlobal");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ABC a = new ABC();
            a.Network();
            IACT i = new ABC();
            i.Network();
            IGlobal g = new ABC();
            g.Network();





        }
    }
}
