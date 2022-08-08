using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTime
{
    interface IStudentService
    {
        Object AddStudent(string name, string id, byte age, byte standard, string city);
        Object UpdateStudentAge(string id, byte age);
        Object UpdateStudentCity(string id, string city);
        void DisplayAll();
        bool DeleteStudent(string id);
    }
}
