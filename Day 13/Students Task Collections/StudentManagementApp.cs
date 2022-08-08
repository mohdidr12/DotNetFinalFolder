using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Task_Collection
{
    class StudentManagementApp
    {
        static void Main(string[] args)
        {
            StudentManagementIO student = new StudentManagementIO();
            bool flag = true;
            while (flag)
            {
                switch (student.Menu())
                {
                    case 1:
                        student.AddStudent();
                        break;

                    case 2:
                        student.DisplayAll();
                        break;

                    case 3:
                        student.UpdateStudent();
                        break;

                    case 4:
                        student.DeleteStudent();
                        break;

                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}
