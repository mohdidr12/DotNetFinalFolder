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
        public ActionResult Links()
        {
            demo_1Entities dbcontext = new demo_1Entities();
            List<tb2Employees> emplist = dbcontext.tb2Employees.ToList();
            return View(emplist);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]

        public RedirectResult InsertData(tb2Employees emp)
        {
            demo_1Entities dbcontext = new demo_1Entities();
            dbcontext.tb2Employees.Add(emp);
            dbcontext.SaveChanges();
            return Redirect("Index");
        }

        public ActionResult Delete(int id)
        {
            demo_1Entities dbContext = new demo_1Entities();
            var item = dbContext.tb2Employees.FirstOrDefault(x => x.Id == id);
            return View(item);
        }

        [HttpPost]

        public RedirectResult DeleteData(int id)
        {
            demo_1Entities dbContext = new demo_1Entities();
            var item = dbContext.tb2Employees.FirstOrDefault(x => x.Id == id);
            dbContext.tb2Employees.Remove(item);
            dbContext.SaveChanges();
            return Redirect("/Employee/Index");
        }

        public ActionResult Update(int id)
        {
            demo_1Entities dbcontext = new demo_1Entities();
            var item = dbcontext.tb2Employees.FirstOrDefault(x => x.Id == id);
            return View(item);
        }


        [HttpPost]

        public RedirectResult UpdateData(tb2Employees emp)
        {
            demo_1Entities dbcontext = new demo_1Entities();
            var item = dbcontext.tb2Employees.FirstOrDefault(x => x.Id == emp.Id);
            item.Name = emp.Name;
            item.DateOfBirth = emp.DateOfBirth;
            item.DepartmentId = emp.DepartmentId;
           
            dbcontext.SaveChanges();
            return Redirect("/Employee/Index");
        }



    }
}