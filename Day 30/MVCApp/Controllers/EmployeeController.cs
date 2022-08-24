using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp.Models;
using MVCApp.ViewModels;

namespace MVCApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ViewResult Details()
        {
            Employee employee = new Employee()
            {
                EmployeeId=23,
                Name = "Idris",
                Gender = "Male",
                Department = "IT",
                Salary = 10000000,
                AddressId = 1001
            };
            Address address = new Address()
            {
                AddressId=1,
                Country="India",
                State="Rajasthan",
                City="Jaipur",
                Pin="302002"
            };
            EmployeeDetailsViewModel employeeDetailsViewModel = new EmployeeDetailsViewModel()
            {
                Employee = employee,
                Address =  address,
                PageTitle = "Employee Details Page",
                PageHeader = "Employee Details"

            };
            return View(employeeDetailsViewModel);
        }
    }
}