using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCActionResult.Models;

namespace MVCActionResult.Controllers
{
    public class ResultTypeController : Controller
    {
        // GET: ResultType
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult ShowEmployee()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 1,
                FirstName = "Mohd",
                LastName = "idris",
                Location = "Jaipur",
                Email = "mohd@gmail.com"
            };
            return View(employee);
            
        }
        public ContentResult ContentResultTest()
        {
            return Content("<b> Hello from GL</b>", "text/html,System.Text.Encoding.UTF8");

        }
        public RedirectResult RedirectResultTest()
        {
            return Redirect("https://google.com");
        }
        public FileResult FileResultTest()
        {
            return File("~/downloads/PANCARD.pdf", "application/pdf");
        }
        public HttpStatusCodeResult StatusCodeResultTest()
        {
            var status = new HttpStatusCodeResult(200);
            return status;
            
        }
    }
}