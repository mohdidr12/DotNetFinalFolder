﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutDemo
{
    class tryref
    {
        public void mul(ref int i,ref int j)
        {
            j = i * j;
            Console.WriteLine("the value of k{0}", j);
        }
        public void add(int x,int y)
        {
            int k = x + y;
            Console.WriteLine("the value of k{0}", k);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            tryref tf = new tryref();
            int i = 5;
            int j = 10;
            Console.WriteLine("The value of i and j before the call: " + i + "," + j);
            tf.mul(ref i, ref j);
            tf.add(i, j);
            Console.WriteLine("The value of i and j after the call" + i + "," + j);
            int m;
         // Console.WriteLine("previous value of integer m" + m.ToString());
            string text = GetNamebyOut(out m);
            Console.WriteLine("Current value of integer m" + m.ToString());
            Console.ReadLine();
        }
        public static string GetNamebyOut(out int d)
        {
            d = 50;
            string returntext = d.ToString();
            return returntext;
        }
    }
 }
    