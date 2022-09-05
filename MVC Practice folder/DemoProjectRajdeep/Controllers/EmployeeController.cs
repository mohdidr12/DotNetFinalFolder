using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoProjectRajdeep.Models;

namespace DemoProjectRajdeep.Controllers
{
    public class EmployeeController : Controller
    {

        static IList<Employee> empList = new List<Employee>();

           
      
        public ActionResult Index()
        {
            return View(empList.OrderBy(s => s.Id).ToList());


          
           
            
        }

      
        public ActionResult Details(int id)
        {
           var row =  empList.FirstOrDefault(x => x.Id == id);
            return View(row);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }
      


        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee e)
        {
            try
            {
                
                empList.Add(e);
               return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            var row = empList.FirstOrDefault(x => x.Id == id);
            return View(row);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(Employee e)
        {
            try
            {
                var student = empList.Where(s => s.Id == e.Id).FirstOrDefault();
                empList.Remove(student);
                empList.Add(e);
               
             


                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            var row = empList.FirstOrDefault(x => x.Id == id);
            return View(row);
            
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(Employee e)
        {
            try
            {
                var row = empList.FirstOrDefault(x => x.Id == e.Id);
                empList.Remove(row);
                 
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
