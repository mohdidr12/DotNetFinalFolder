using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Practice.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public string Index()
        {
            return "Welcone to MVC";
        }
        public string About(string name)
        {
            return "Welcome" + name;
        }
    }
}