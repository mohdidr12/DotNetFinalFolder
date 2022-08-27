using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFEntitycf.Models;
using System.Data.Entity;

namespace EFEntitycf.Controllers
{
    public class StudentController : Controller
    {
        StudentContext db = new StudentContext();   
        public ActionResult Index()
        {
           var data = db.Students.ToList();
            return View(data);

            
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student s)
        {
            if(ModelState.IsValid==true)
            {
                db.Students.Add(s);
               int n= db.SaveChanges();
                if(n>0)
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
            var row = db.Students.Where(model => model.Id == id).FirstOrDefault();
            return View(row);
        }
        [HttpPost]
        public ActionResult Edit(Student s)
        {
            if (ModelState.IsValid == true)
            {
                db.Entry(s).State = EntityState.Modified;
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
        public ActionResult Delete(int id)
        {
            var studentRow = db.Students.Where(model => model.Id == id).FirstOrDefault();
            return View(studentRow);
        }
        [HttpPost]
        public ActionResult Delete(Student s)
        {
            if (ModelState.IsValid == true)
            {
                db.Entry(s).State = EntityState.Deleted;
                int n = db.SaveChanges();
                if (n > 0)
                {
                    TempData["DeleteMessage"] = "The Data is Deleted Successfully";
                    
                }
                else
                {
                    TempData["DeleteMessage"] = "The Data is Not  Deleted";
                }
            }
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var RowDetails = db.Students.Where(model => model.Id == id).FirstOrDefault();
            return View(RowDetails);
        }
    }
}