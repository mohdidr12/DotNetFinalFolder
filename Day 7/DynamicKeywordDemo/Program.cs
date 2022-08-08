using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicKeywordDemo
{
    public class Author
    {
        dynamic name;
        dynamic Nameproperty { get; set; }
        public dynamic FullNameMethod(dynamic d)
        {
            name = "Mahesh";
            dynamic firstname = name;
            return firstname + " " + d;
        }
    }
    class Program
    {
        static void MyDynamicMethod(dynamic dynamicparam)
        {
            dynamic lastName = "Kumar";
            dynamic dynAuthor = new Author();
            Console.WriteLine(dynAuthor.FullNameMethod(lastName));
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            MyDynamicMethod("dynamicparam");
        }
    }
}
