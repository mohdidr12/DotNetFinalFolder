using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Data.Entity;
using System.Web.Mvc;
using PracticeCategoryProductEF.Models;

namespace PracticeCategoryProductEF.Controllers
{
    
    public class CategoryController : Controller
    {
        ProductStore db = new ProductStore();
        // GET: Category
        public ActionResult Index()
        {
            var data = db.categories.ToList();
            return View(data);
           
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category c)
        {
            if (ModelState.IsValid == true)
            {
                db.categories.Add(c);
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
            var row = db.categories.Where(model => model.CategoryId == id).FirstOrDefault();
            return View(row);
        }
        [HttpPost]
        public ActionResult Edit(Category c)
        {
            if (ModelState.IsValid == true)
            {
                db.Entry(c).State = EntityState.Modified;
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
        public ActionResult Delete(int?id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            Category category = db.categories.Find(id);
            db.categories.Remove(category);
           int n = db.SaveChanges();
            if(n>0)
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
            var RowDetails = db.categories.Where(model => model.CategoryId == id).FirstOrDefault();
            return View(RowDetails);
        }
    }
}