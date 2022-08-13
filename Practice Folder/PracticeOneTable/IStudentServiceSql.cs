using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOneTable
{
    interface IStudentServiceSql
    {
        void AddData(string id, string name, byte age, byte standard, string city);
        void UpdateAge(string id, byte age);
        void UpdateCity(string id, string city);
        void Delete(string id);
        void DisplayAll();
    }
}
