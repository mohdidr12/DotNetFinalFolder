﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Multi_DELEGATE
{
    public delegate void MultiCastDelegate(int a, int b);

    class Program
    {
        public void Add(int x, int y)
        {
            Console.WriteLine("Sum=" + (x + y));
        }
        public void Subtract(int x, int y)
        {
            Console.WriteLine("Subtract=" + (x - y));
        }
        public void Multiply(int x, int y)
        {
            Console.WriteLine("Multiply=" + (x * y));
        }
        public void Divide(int x, int y)
        {
            Console.WriteLine("Divide=" + (x / y));
        }
       
        static void Main(string[] args)
        {
            Program obj1 = new Program();
            MultiCastDelegate objD = new MultiCastDelegate(obj1.Multiply);
            //objD += obj1.Add;
            //objD += obj1.Subtract;
            //objD += obj1.Divide;
            //objD(40, 10);
            //objD -= obj1.Add;
            //objD -= obj1.Divide;
            //objD(50, 10);
            foreach(MultiCastDelegate dele in objD.GetInvocationList())
            { 
                try
                {
                    dele.Invoke(40,32);

                }
                catch(Exception ex)
                {
                    Console.WriteLine(dele.Method.Name,ex.Message);
                }
                }
            //objD.GetInvocationList();
                Console.ReadLine();


        }
    }
}
