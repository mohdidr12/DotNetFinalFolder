using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Code_Assessment_7_Asp.net_Mvc.Models;
using System.Data.Entity;
using System.Net;
using Code_Assessment_7_Asp.net_Mvc.CustomFilter;


namespace Code_Assessment_7_Asp.net_Mvc.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDepartment db = new EmployeeDepartment();
        // GET: Employee
        public ActionResult Index()
        {
            var products = db.employees.Include(p => p.department);
            return View(products.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [CustomExceptionHandlerFilter]
        public ActionResult Create(Employee e)
        {
            if (ModelState.IsValid == true)
            {
                if (e.Salary <= 0 )
                {
                    throw new NotImplementedException();  
                }
                else
                {
                    db.employees.Add(e);
                    int n = db.SaveChanges();
                    if (n > 0)
                    {
                        // ViewBag.InsertMessage = "<script>alert('Data Inserted !!')</script>";
                        TempData["Message"] = "Data Inserted !!";
                        // ModelState.Clear();
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ViewBag.InsertMessage = "<script>alert('Data  Not Inserted !!')</script>";
                    }
                   
                }
                
            }
            return View();

        }
        public ActionResult Edit(int id)
        {
            var row = db.employees.Where(model => model.EmployeeId == id).FirstOrDefault();
            return View(row);
        }
        [HttpPost]
        public ActionResult Edit(Employee e)
        {
            if (ModelState.IsValid == true)
            {
                db.Entry(e).State = EntityState.Modified;
                int n = db.SaveChanges();
                if (n > 0)
                {
                    //  ViewBag.UpdateMessage = "<script>alert('Data Updated')</script>";
                    TempData["UpdateMessage"] = "Data is Updated";
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.UpdateMessage = "<script>alert('Data Not Updated')</script>";
                }
            }
            return View();
        }
        public ActionResult Delete(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Employee employee = db.employees.Find(id);
            db.employees.Remove(employee);
            int n = db.SaveChanges();
            if (n > 0)
            {
                TempData["DeleteMessage"] = "The Data is Deleted Successfully";
            }
            else
            {
                TempData["DeleteMessage"] = "The Data is Not  Deleted";
            }
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var RowDetails = db.employees.Where(model => model.EmployeeId == id).FirstOrDefault();
            return View(RowDetails);
        }
    }
}