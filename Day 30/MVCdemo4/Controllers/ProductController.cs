using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCdemo4.Models;

namespace MVCdemo4.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
               new Product{ProductID=1,Name="Apple",Category="Mobile",Description="Iphone 6" , Price=9000000},
               new Product{ProductID=2,Name="Samsung",Category="Washing",Description="Samsung 78 i" , Price=8900000},
               new Product{ProductID=3,Name="Nokia",Category="Phone",Description="Nokia 78 i" , Price=8000},
               new Product{ProductID=4,Name="MI",Category="TV",Description="MIg 78 i" , Price=78000},
               new Product{ProductID=5,Name="VIVO",Category="Mobile",Description="VIVO 78 i" , Price=55000},
               new Product{ProductID=6,Name="One Plus",Category="gadgets",Description="One Plus 78 i" , Price=789999}

            };
            return View(products);
        }
        public PartialViewResult GetProducts()
        {
            List<Product> products = new List<Product>()
            {
        new Product{ProductID=1,Name="Apple",Category="Mobile",Description="Iphone 6" , Price=9000000},
               new Product{ProductID=2,Name="Samsung",Category="Washing",Description="Samsung 78 i" , Price=8900000},
               new Product{ProductID=3,Name="Nokia",Category="Phone",Description="Nokia 78 i" , Price=8000},
               new Product{ProductID=4,Name="MI",Category="TV",Description="MIg 78 i" , Price=78000},
               new Product{ProductID=5,Name="VIVO",Category="Mobile",Description="VIVO 78 i" , Price=55000},
               new Product{ProductID=6,Name="One Plus",Category="gadgets",Description="One Plus 78 i" , Price=789999}
            };
            return PartialView("ProductDetails", products);
        }
    }
}