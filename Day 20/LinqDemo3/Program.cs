using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo3
{
    public class Student
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
            //linq query to fetch all students with Gender male
            IEnumerable<Student> QuerySyntax = from std in studentList
                                               where std.Gender == "Female"
                                               select std;

            //Iterate through the collection
            foreach(var student in QuerySyntax)
            {
                
                Console.WriteLine($"ID : {student.ID} Name : {student.Name}");
            }
            Console.ReadKey();
        }
    }
}
