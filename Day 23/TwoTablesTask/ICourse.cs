using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoTablesPractice
{
    interface ICourse
    {
        void AddCourse(int id,int c_id, string c_name);
        void UpdateCourse(int c_id, string c_name);
        void DisplayCourse();
        void DeleteCourse(int c_id);
        void DisplayEnrollStudent();
    }
}
