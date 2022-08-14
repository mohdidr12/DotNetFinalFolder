using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DemoEOD
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new demo_1Entities())
            {
                var result = context.Students;
                foreach(var item in result)
                {
                    Console.WriteLine(" "+item.Id);
                    Console.WriteLine(" " +item.Name);
                    Console.WriteLine(" " +item.salary);
                    Console.ReadLine();
                }
            }
        }
    }
}
