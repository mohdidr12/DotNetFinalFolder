using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerDemoEmpty.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        //public string GetEmployeeById(int id)
        //{
        //    if(id==1)
        //    {
        //        return "Employee 1 Id";
        //    }
        //    else if(id==2)
        //        {

        //        return "Employee 2 Id";
        //         }
        //    else
        //    {
        //        return "No Employee found";
        //    }
        //}
        //public string GetEmployeeDept(int id , int?dept=null)
        //{
            
            
        //        return "Employee "+id+"Department "+dept;
            
        // }
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult AboutUs()
        {
            return View();
        }
    }
}