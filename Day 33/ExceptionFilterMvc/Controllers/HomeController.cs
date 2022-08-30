using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExceptionFilterMvc.Controllers
{
    
    public class HomeController : Controller
    {
       [HandleError(View = "Error")]
        public ActionResult Index()
        {
            
            throw new Exception();
           
            
        }

        [HandleError(View = "Error2")]
        public ActionResult About()
        {
            throw new Exception();

            
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}