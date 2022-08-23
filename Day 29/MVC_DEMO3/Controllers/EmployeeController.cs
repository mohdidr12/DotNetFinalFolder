using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_DEMO3.Models;

namespace MVC_DEMO3.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeBusinessLayer obj = new EmployeeBusinessLayer();
            Employee Emp = obj.GetEmployeeDetails();
            ViewData["Employee"] = Emp;
            ViewData["Header"] = "Employee Details";

            return View();
        }
    }
}