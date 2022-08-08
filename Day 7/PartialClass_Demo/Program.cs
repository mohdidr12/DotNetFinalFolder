using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeClass emp = new EmployeeClass();
            emp.FirstName = "Aradhya";
            emp.LastName = "Singh";
            emp.Salary = 1000000;
            emp.Gender = "Female";
            emp.DisplayFullName();
            emp.DisplayEmployeeDetails();
        }
    }
}
