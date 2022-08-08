using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionGeekDemo
{
    class Program:System.Exception
    {
        static void Main(string[] args)
        {
             int[] arr = { 1, 0, 3, 4, 5 };
            for(int i=0;i<arr.Length;i++)
            {
                try
                {
                    Console.WriteLine(arr[i] / arr[i + 1]);
                }
                
                catch(IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch(DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch(ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
          
        }
    }
}
