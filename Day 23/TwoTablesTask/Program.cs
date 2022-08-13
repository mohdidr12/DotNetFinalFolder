using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoTablesPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Boolean flag = true;
            IOStudentCourse inp = new IOStudentCourse();
            while (flag)
            {
                Console.WriteLine("*****************************************");
                Console.WriteLine("Select Operation from Student");
                Console.WriteLine("1.Insert Student");
                Console.WriteLine("2.Update Student");
                Console.WriteLine("3.Delete Student");
                Console.WriteLine("4.Display Students");
                Console.WriteLine("Select Operation from Course");
                Console.WriteLine("5.Insert Course");
                Console.WriteLine("6.Update Course");
                Console.WriteLine("7.Delete Course");
                Console.WriteLine("8.Display Courses");
                Console.WriteLine("*****************************************");
                Console.WriteLine("9.Display Student Enroll in Course");
                Console.WriteLine("*****************************************");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        inp.InsertValuesStudent();
                        break;
                    case 2:
                        inp.UpdateStudentValues();
                        break;
                    case 3:
                        inp.DeleteStudent();
                        break;
                    case 4:
                        inp.DisplayDataStudent();
                        break;
                    case 5:
                        inp.InsertCourseUser();
                        break;
                    case 6:
                        inp.UpdateCourseUser();
                        break;
                    case 7:
                        inp.DeleteCourseUser();
                        break;
                    case 8:
                        inp.DisplayCourseUser();
                        break;
                    case 9:
                        inp.Enroll_student_info();
                        break;
                    default:
                        Console.WriteLine("No Valid Option from the Above Selection ");
                        flag = false;
                        break;

                }
            }
        }
    }
}
          

