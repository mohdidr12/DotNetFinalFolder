using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    interface IACT
    {
        void Network();
    }
    class Abc : Iwork,IACT,ICommunication
    {
        public void Add()
        {
            Console.WriteLine("I am from IWork interface");
        }
        public int Calc()
        {
            int result;
            result = 55;
            return result;
        }
        
        public void CNN()
        {
            
            Console.WriteLine("I am from ICommunication interface");
        }
        public void Network()
        {
            Console.WriteLine("I am from IACT interface");
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Abc obj = new Abc();
            obj.Add();
            obj.Calc();
            obj.Network();
            XYZ objx = new XYZ();
            objx.Calc();
            objx.Add();
        }
    }
}
