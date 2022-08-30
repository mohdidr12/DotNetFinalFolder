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
                //     db.Entry(p).State = EntityState.Modified;
                Product producttoUpdate = db.products.FirstOrDefault(x => x.ProductId == p.ProductId);
                producttoUpdate.ProductName = p.ProductName;
                producttoUpdate.Price = p.Price;
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
            var productRow = db.products.Where(model => model.ProductId == id).FirstOrDefault();
            if(productRow!=null)
            {

                Product productdelete = db.products.FirstOrDefault(x => x.ProductId == productRow.ProductId);
                db.products.Remove(productdelete);
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
            var RowDetails = db.products.Where(model => model.ProductId == id).FirstOrDefault();
            return View(RowDetails);
        }

    }
}