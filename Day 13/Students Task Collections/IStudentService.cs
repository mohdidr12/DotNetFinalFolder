using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Task_Collection
{
    interface IStudentService
    {
        Student AddStudent(string name, string id, byte age, byte standard, string city);
        Student GetStudentByID(string id);
        Student UpdateStudentAge(string id, byte age);
        Student UpdateStudentCity(string id, string city);
        void DisplayAll();
        bool DeleteStudent(string id);

    }
}
