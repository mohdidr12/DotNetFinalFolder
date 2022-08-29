using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Code_Assessment_7_Asp.net_Mvc.Models;
using System.Data.Entity;
using System.Net;

namespace Code_Assessment_7_Asp.net_Mvc.Controllers
{
    public class DepartmentController : Controller
    {
        EmployeeDepartment db = new EmployeeDepartment();
        // GET: Department
        public ActionResult Index()
        {
            var data = db.departments.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Department d)
        {
            if (ModelState.IsValid == true)
            {
                db.departments.Add(d);
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
            return View();

        }
        public ActionResult Edit(int id)
        {
            var row = db.departments.Where(model => model.DepartmentId == id).FirstOrDefault();
            return View(row);
        }
        [HttpPost]
        public ActionResult Edit(Department d)
        {
            if (ModelState.IsValid == true)
            {
                db.Entry(d).State = EntityState.Modified;
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
            Department department = db.departments.Find(id);
            if (department == null)
            {
                return HttpNotFound();
            }
            return View(department);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            Department department = db.departments.Find(id);
            db.departments.Remove(department);
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
            var RowDetails = db.departments.Where(model => model.DepartmentId == id).FirstOrDefault();
            return View(RowDetails);
        }
    }
}