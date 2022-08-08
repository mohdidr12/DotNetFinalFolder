using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {

            Student s1 = new Student { Id = 101, Name = "idris", Marks = 505 };
            Student s2 = new Student { Id = 99, Name = "musab", Marks = 505 };
            Student s3 = new Student { Id = 102, Name = "Arslan", Marks = 100 };
            List<Student> Students = new List<Student> { s1, s2, s3 };
            foreach(Student S in Students)
            {
                Console.WriteLine(S.Id + " " + S.Name + " " + S.Marks);
            }
        }
    }
}
