using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAgain.Models;

namespace MVCAgain.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index(int Id)
        {
            EmployeeBusinessLayer bl = new EmployeeBusinessLayer();
            Employee employee = bl.GetEmployeeDetails(Id);
            return View();
        }
    }
}