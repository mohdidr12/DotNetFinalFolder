using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class DataaccessHelper
    {
        CodeFirstContext _dbcontext = new CodeFirstContext();
        public List<Employee> FetchEmployees()
        {
            return _dbcontext.Employees.ToList();
        }
        public List<Department> FetchDepartments()
        {
            return _dbcontext.Departments.ToList();
        }
        public int Add(Employee employee)
        {
            _dbcontext.Employees.Add(employee);
            _dbcontext.SaveChanges();
            return employee.EmployeeId;
        }

        public int AddDept(Department department)
        {
            _dbcontext.Departments.Add(department);
            _dbcontext.SaveChanges();
            return department.DepartmentId;

        }
    }
}
