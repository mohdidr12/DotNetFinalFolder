using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo4
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>()
            {
                new Student(){ID=1,Name="Anmol",Gender="Male"},
                new Student(){ID=2,Name="Prarthana",Gender="Female"},
                new Student(){ID=3,Name="Rishab",Gender="Male"},
                new Student(){ID=4,Name="Muskan",Gender="Female"},

            };
            // linq wuery to fetch all students with gender Male
            IQueryable<Student> MethodSyntax = studentList.AsQueryable()
                               .Where(std => std.Gender == "Male");

            //iterate trough the collection
            foreach(var student in MethodSyntax)
            {
                Console.WriteLine($"ID : {student.ID} Name :{student.Name}");
            }
            Console.ReadKey();
        }
    }
    }

