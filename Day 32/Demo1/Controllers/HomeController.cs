using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo1.Controllers.Filters;

namespace Demo1.Controllers
{
    public class HomeController : Controller
    {
        [CustomAuthorization]
        [CustomAction]
        [CustomResultAttribute]
        [CustomExceptionAttribute]

        public ActionResult Index()
        {
            ViewBag.Message = "Index Action of Home Controller is being called";
            return View();
        }

      

       
        
    }
}