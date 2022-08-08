using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTime
{
    class StudentManagementIODemo
    {
        StudentServiceDemo studentservice = new StudentServiceDemo();

        public byte Menu()
        {
            Console.WriteLine("Press 1 to Add Student");
            Console.WriteLine("Press 2 to View All Students");
            Console.WriteLine("Press 3 to Update Student");
            Console.WriteLine("Press 4 to Delete Student");
            Console.WriteLine("Press 5 to Exit");
            Console.WriteLine("Enter Your choice:");

            try
            {
                byte option = Convert.ToByte(Console.ReadLine());
                return option;
            }
            catch(Exception e)
            {
                Console.WriteLine("Enter a Valid Input\n");
                return Menu();
            }
        }
        public void AddStudent()
        {
            try
            {
                Console.WriteLine("Enter Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter ID:");
                string id = Console.ReadLine();
                Console.WriteLine("Enter Age:");
                byte age = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Enter Class:");
                byte standard = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Enter City:");
                string city = Console.ReadLine();
                Student student = studentservice.AddStudent(name, id, age, standard, city);
               // Display(student);
                Console.WriteLine("".PadLeft(15, '-'));
            }
            catch (Exception)
            {
                Console.WriteLine("Enter a Valid Input\n");
                AddStudent();
            }

        }
    }
}
