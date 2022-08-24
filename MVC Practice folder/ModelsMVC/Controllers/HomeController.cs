using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelsMVC.Models;

namespace ModelsMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var data = GetEmployee();
            return View(data);
        }
        public Employee GetEmployee()
        {
           return new Employee()
            {
                Id=1,
                Name="idris",
                Address="Jaipur"
            };
        }
    }
}