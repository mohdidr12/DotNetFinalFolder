using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredPracticeTwoTable
{
    class IOStudentCourse
    {
        Connection sc = new Connection();
        public void InsertValuesStudent()
        {
            Console.WriteLine("Enter id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            byte age = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter standard");
            byte standard = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter City");
            string city = Console.ReadLine();
            sc.AddStudent(id, name, age, standard, city);
        }
        public void DisplayDataStudent()
        {
            sc.CountOfStudents();
            sc.DisplayAll();

        }
        public void UpdateStudentValues()
        {
            Console.WriteLine("select which want you to Update");
            Console.WriteLine("1.UpdateAge\n 2.UpdateCity\n");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("enter Id of Student");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter Updated Age of Student");
                    byte upAge = byte.Parse(Console.ReadLine());
                    sc.UpdateAge(id, upAge);
                    break;
                case 2:
                    Console.WriteLine("enter Id of Student");
                    int Id = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter Updated City of Student");
                    string upcity = Console.ReadLine();
                    sc.UpdateCity(Id, upcity);
                    break;
                default:
                    Console.WriteLine("please enter the valid Option");
                    break;
            }
        }
        public void DeleteStudent()
        {
            Console.WriteLine("enter id of student which you want to delete");
            int id = int.Parse(Console.ReadLine());
            sc.DeleteStudent(id);
        }
        public void InsertCourseUser()
        {
            Console.WriteLine("Enter Student id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Course id");
            int c_id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Course name");
            string c_name = Console.ReadLine();
            sc.AddCourse(id, c_id, c_name);
        }
        public void UpdateCourseUser()
        {

            Console.WriteLine("Enter Course  id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Updated Course name");
            string c_name = Console.ReadLine();
            sc.UpdateCourse(id, c_name);
        }
        public void DeleteCourseUser()
        {
            Console.WriteLine("Enter Course  id");
            int id = int.Parse(Console.ReadLine());
            sc.DeleteCourse(id);

        }
        public void DisplayCourseUser()
        {
            sc.CountOfCourse();
            sc.DisplayCourse();

        }
        public void Enroll_student_info()
        {
            sc.DisplayEnrollStudent();
        }
    }
}
