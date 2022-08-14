using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataaccessHelper dbHelper = new DataaccessHelper();
            Department dept = new Department()
            {
                DepartmentName = "IT Department",
                Employees = new List<Employee>
                            {
                             new Employee(){ EmployeeName="Ram"},
                             new Employee(){ EmployeeName="Sham"},
                             new Employee(){ EmployeeName="Jamm"},
                             }
            };
            dbHelper.AddDept(dept);

            var AddedDeptValues = dbHelper.FetchDepartments().FirstOrDefault();
            if (AddedDeptValues != null)
            {
                Console.WriteLine(AddedDeptValues.DepartmentName);
                Console.WriteLine("List of Department Employees are");
                foreach(var AddedDeptEmployees in AddedDeptValues.Employees)
                {
                    Console.WriteLine(AddedDeptEmployees.EmployeeName);
                    Console.ReadLine();
                }
            }
        }
    }
}
