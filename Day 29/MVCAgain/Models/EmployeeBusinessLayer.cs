using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAgain.Models
{
    public class EmployeeBusinessLayer
    {
        public Employee GetEmployeeDetails(int EmployeeId)
        {
            Employee employee = new Employee
            {
                EmployeeId = 1,
                Name = "Idris",
                Address = "Ramgarh Mode",
                Gender = "Male",

            };
            return employee;
        }

    }
}