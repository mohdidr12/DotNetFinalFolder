using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integerList = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };
            //linq query using method syntax
            var MethodSyntax = integerList.Where(obj => obj > 6).ToList();

            foreach(var item in MethodSyntax)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
