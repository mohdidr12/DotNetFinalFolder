using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoIndividualUserAcc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult NonSecured()
        {
            return View();
        }
        [Authorize]
        public ActionResult Secured()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
       

      
    }
}