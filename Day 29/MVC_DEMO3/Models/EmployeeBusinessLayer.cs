using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVC_DEMO3.Models
{
    public class EmployeeBusinessLayer
    {
        public Employee GetEmployeeDetails()
        {
            Employee employee = new Employee() { EmployeeId = 1, Name = "Idris", Address = "Rajasthan", City = "Jaipur", Gender = "Male", Salary = 50000};

            return employee;
        }
    }
}