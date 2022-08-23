using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeRegistrationMvc.Controllers
{
    public class EmployeeRegistrationController : Controller
    {
        // GET: EmployeeRegistration
        public ActionResult SaveData()
        {
            ViewBag.result = "";
            return View();
        }
        [HttpPost]
        public ActionResult SaveData(string Ename,string EmpEmail,string contactNo,string city,string state,string country)
        {
            string strcn = "Server = DEL1-LHP -N82101\\MSSQLSERVER01; Database = demo_1; Integrated Security = SSPI";
            SqlConnection conn = new SqlConnection(strcn);
            conn.Open();
           
            SqlCommand cmd = new SqlCommand($"Insert into Emp_Registration(EmpName,EmpEmail,ContactNo,City,State,Country) Values('{Ename}','{EmpEmail}','{contactNo}',{city},'{state}','{country}')",conn);
            cmd.ExecuteNonQuery();
            ViewBag.result = "Registration form has beeen saved successfullly";
            return View();


        }
    }
}