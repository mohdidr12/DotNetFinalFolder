using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDatabaseConnect.Models;

namespace MVCDatabaseConnect.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            demo_1Entities dbcontext = new demo_1Entities();
            List<tb2Employees> empList = dbcontext.tb2Employees.ToList();


            return View(empList);
        }
        public ActionResult Details(int id)
        {
            demo_1Entities dbcontext = new demo_1Entities();
            var emplist = dbcontext.tb2Employees.FirstOrDefault(x => x.Id == id);
            return View(emplist);
        }
    }
}