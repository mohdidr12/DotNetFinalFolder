using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredPracticeTwoTable
{
    interface IStudent
    {
        void AddStudent(int id, string name, byte age, byte standard, string city);
        void UpdateAge(int id, byte age);
        void UpdateCity(int id, string city);
        void DeleteStudent(int id);
        void DisplayAll();
    }
}
