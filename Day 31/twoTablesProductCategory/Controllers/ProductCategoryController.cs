using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using twoTablesProductCategory.Models;

namespace twoTablesProductCategory.Controllers
{
    public class ProductCategoryController : Controller
    {
        // GET: ProductCategory
        public ActionResult CategoryIndex()
        {
            AssessmentDbEntities dbcontext = new AssessmentDbEntities();
            List<Category> cgList = dbcontext.Categories.ToList();
            return View(cgList);
        }
        public ActionResult ProductIndex()
        {
            AssessmentDbEntities dbcontext = new AssessmentDbEntities();
            List<Product> pdList = dbcontext.Products.ToList();
            return View(pdList);
        }
        public ActionResult DetailsCategory(int id)
        {
            AssessmentDbEntities dbcontext = new AssessmentDbEntities();
            var cgList = dbcontext.Categories.FirstOrDefault(x => x.CategoryId == id);
            return View(cgList);
        }
        public ActionResult DetailsProducts(int id)
        {
            AssessmentDbEntities dbcontext = new AssessmentDbEntities();
            var pdList = dbcontext.Products.FirstOrDefault(x => x.ProductId == id);
            return View(pdList);
        }
        public ActionResult InsertCategory()
        {
            return View();
        }

        [HttpPost]

        public RedirectResult InsertDataCategory(Category cg)
        {
            try
            {
                AssessmentDbEntities dbcontext = new AssessmentDbEntities();
                dbcontext.Categories.Add(cg);
                dbcontext.SaveChanges();
                return Redirect("CategoryIndex");
            }
            catch(Exception e)
            {
                return Redirect("CategoryIndex");
            }
        }
        public ActionResult InsertProduct()
        {
            return View();
        }

        [HttpPost]

        public RedirectResult InsertDataProduct(Product pd)
        {
            AssessmentDbEntities dbcontext = new AssessmentDbEntities();
            dbcontext.Products.Add(pd);
            dbcontext.SaveChanges();
            return Redirect("/ProductCategory/ProductIndex");
        }
        public ActionResult DeleteCategory(int id)
        {
            AssessmentDbEntities dbContext = new AssessmentDbEntities();
            var item = dbContext.Categories.FirstOrDefault(x => x.CategoryId == id);
            return View(item);
        }

        [HttpPost]

        public RedirectResult DeleteDataCategory(int id)
        {
            AssessmentDbEntities dbContext = new AssessmentDbEntities();
            var item = dbContext.Categories.FirstOrDefault(x => x.CategoryId == id);
            dbContext.Categories.Remove(item);
            dbContext.SaveChanges();
            return Redirect("/ProductCategory/CategoryIndex");
        }
        public ActionResult DeleteProduct(int id)
        {
            AssessmentDbEntities dbContext = new AssessmentDbEntities();
            var item = dbContext.Products.FirstOrDefault(x => x.ProductId == id);
            return View(item);
        }
        [HttpPost]
        public RedirectResult DeleteDataProduct(int id)
        {
            AssessmentDbEntities dbContext = new AssessmentDbEntities();
            var item = dbContext.Products.FirstOrDefault(x => x.ProductId == id);
            dbContext.Products.Remove(item);
            dbContext.SaveChanges();
            return Redirect("/ProductCategory/ProductIndex");
        }
        public ActionResult UpdateCategory(int id)
        {
            AssessmentDbEntities dbcontext = new AssessmentDbEntities();
            var item = dbcontext.Categories.FirstOrDefault(x => x.CategoryId == id);
            return View(item);
        }


        [HttpPost]

        public RedirectResult UpdateDataCategory(Category cg)
        {
            AssessmentDbEntities dbcontext = new AssessmentDbEntities();
            var item = dbcontext.Categories.FirstOrDefault(x => x.CategoryId == cg.CategoryId);
            item.CategoryName = cg.CategoryName;
         

            dbcontext.SaveChanges();
            return Redirect("/ProductCategory/CategoryIndex");
        }
        public ActionResult UpdateProduct(int id)
        {
            AssessmentDbEntities dbcontext = new AssessmentDbEntities();
            var item = dbcontext.Products.FirstOrDefault(x => x.ProductId == id);
            return View(item);
        }


        [HttpPost]

        public RedirectResult UpdateDataProduct(Product pd)
        {
            AssessmentDbEntities dbcontext = new AssessmentDbEntities();
            var item = dbcontext.Products.FirstOrDefault(x => x.ProductId == pd.ProductId);
            item.ProductName = pd.ProductName;
            item.Price = pd.Price;
            dbcontext.SaveChanges();
            return Redirect("/ProductCategory/ProductIndex");
        }

    }
}