using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PracticeCategoryProductEF.Models;

namespace PracticeCategoryProductEF.Controllers
{
    public class ProductController : Controller
    {
        ProductStore db = new ProductStore();
        // GET: Product
        public ActionResult Index()
        {
            var products = db.products.Include(p => p.category);
            return View(products.ToList());
            
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product p)
        {
            if (ModelState.IsValid == true)
            {
                db.products.Add(p);
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
            var row = db.products.Where(model => model.ProductId == id).FirstOrDefault();
            return View(row);
        }
        [HttpPost]
        public ActionResult Edit(Product p)
        {
            if (ModelState.IsValid == true)
            {
                db.Entry(p).State = EntityState.Modified;
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
            Product product = db.products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Product product = db.products.Find(id);
            db.products.Remove(product);
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
            var RowDetails = db.products.Where(model => model.ProductId == id).FirstOrDefault();
            return View(RowDetails);
        }

    }
}