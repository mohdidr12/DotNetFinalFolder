using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelState_Demo.Models;


namespace ModelState_Demo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            TaskEntities dbcontext = new TaskEntities();
            List<Employee> emplist = dbcontext.Employees.ToList();
            return View(emplist);
        }
        
        public ActionResult Details(Employee emp)
        {
            TaskEntities dbcontext = new TaskEntities();
            var empList = dbcontext.Employees.FirstOrDefault(x => x.ID == emp.ID);
            return View(empList);
        }

        public ActionResult Links()
        {
            TaskEntities dbcontext = new TaskEntities();
            List<Employee> emplist = dbcontext.Employees.ToList();
            return View(emplist);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]

        public RedirectResult InsertData(Employee emp)
        {
            TaskEntities dbcontext = new TaskEntities();
            dbcontext.Employees.Add(emp);
            dbcontext.SaveChanges();
            return Redirect("Index");
        }

        public ActionResult Delete(int id)
        {
            TaskEntities dbContext = new TaskEntities();
            var item = dbContext.Employees.FirstOrDefault(x => x.ID == id);
            return View(item);
        }

        [HttpPost]

        public RedirectResult DeleteData(int id)
        {
            TaskEntities dbContext = new TaskEntities();
            var item = dbContext.Employees.FirstOrDefault(x => x.ID == id);
            dbContext.Employees.Remove(item);
            dbContext.SaveChanges();
            return Redirect("/Employee/Index");
        }

        public ActionResult Update(int id)
        {
            TaskEntities dbcontext = new TaskEntities();
            var item = dbcontext.Employees.FirstOrDefault(x => x.ID == id);
            return View(item);
        }

        [HttpPost]

        public RedirectResult UpdateData(Employee emp)
        {
            TaskEntities dbcontext = new TaskEntities();
            var item = dbcontext.Employees.FirstOrDefault(x => x.ID == emp.ID);
            item.Name = emp.Name;
            item.ProjectID = emp.ProjectID;
            item.Gender = emp.Gender;
            item.Salary = emp.Salary;
            dbcontext.SaveChanges();
            return Redirect("/Employee/Index");
        }
    }
}