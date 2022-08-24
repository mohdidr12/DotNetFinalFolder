using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPartial.Models;

namespace MVCPartial.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
               new Product{ProductID=1,Name="Apple",Category="Mobile",Description="Iphone 6" , Price=9000000},
              

            };
            return View(products);
        }
        public PartialViewResult GetProducts()
        {
            List<Product> products = new List<Product>()
            {
             new Product{ProductID=1,Name="Apple",Category="Mobile",Description="Iphone 6" , Price=9000000},
              
            };
            return PartialView("ProductDetails", products);
        }
    }
}