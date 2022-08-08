using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalStudentOops
{
    class Student
    {
        int id, total_marks;
        string name, city;
        public int Id
        {
            get { return id; }
            set { id = value; }

        }
        public int TotalMarks
        {
            get { return total_marks; }
            set { total_marks = value; }

        }
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public string City
        {
            get { return city; }
            set { city = value; }

        }
        public void Create(Student s1)
        {
            Console.WriteLine("Enter The Student id");
            s1.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Student total marks obtained");
            s1.TotalMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Student name");
            s1.Name = Console.ReadLine();
            Console.WriteLine("Enter the Student city");
            s1.City = Console.ReadLine();
        }
        public void Update(Student s1)
        {
            Console.WriteLine("what you have to update?\n1.Id\n2.Name\n3.Total Marks\n4.City");
            Console.WriteLine("Enter one option");
            int opt = int.Parse(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    Console.WriteLine("enter the updated id");
                    s1.Id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Id successfully updated");
                    break;
                case 2:
                    Console.WriteLine("enter the updated Name");
                    s1.Name = Console.ReadLine();
                    Console.WriteLine("Name successfully updated");
                    break;
                case 3:
                    Console.WriteLine("enter the updated Total Marks");
                    s1.TotalMarks = int.Parse(Console.ReadLine());
                    Console.WriteLine("Marks successfully updated");
                    break;
                case 4:
                    Console.WriteLine("enter the updated city");
                    s1.City = Console.ReadLine();
                    Console.WriteLine("city successfully updated");
                    break;
                default:
                    Console.WriteLine("Invalid Option.");
                    break;
            }
        }
        public void Delete(Student s1)
        {
            s1 = null;
            Console.WriteLine("the record of student deleted successfully");
        }
        public void Exit()
        {
            System.Environment.Exit(1);
        }
        public void printDetails(Student s1)
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine("id is: " + s1.Id);
            Console.WriteLine("Name is: " + s1.Name);
            Console.WriteLine("Total Marks is: " + s1.TotalMarks);
            Console.WriteLine("City is " + s1.City);
            Console.WriteLine("*********************************************************");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 3; i++)
            {
                Student s1 = new Student();
                Console.WriteLine("what you want to do?\n1.Create student Record\n2.Update Student Record\n3.Delete the existing Record\n4.Exit");
                Console.WriteLine("enter the choice ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        s1.Create(s1);
                        s1.printDetails(s1);
                        break;
                    case 2:
                        s1.Update(s1);
                        break;
                    case 3:
                        s1.Delete(s1);
                        break;
                    case 4:
                        s1.Exit();
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }

        }
    }
}

