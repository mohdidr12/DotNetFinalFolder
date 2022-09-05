using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LearningApiDemo.Controllers
{
    public class EmployeesDataController : ApiController
    {
        public string[] myEmployees = { "Adil", "Amit", "Idris", "Juned" };
        [HttpGet]
        public string[] GetEmployees()
        {
            return myEmployees;
        }
        [HttpGet]
        public string GetEmployeesById(int id)
        {
            return myEmployees[id];
        }
    }
}
