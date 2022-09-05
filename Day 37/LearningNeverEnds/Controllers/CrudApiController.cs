using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LearningNeverEnds.Models;

namespace LearningNeverEnds.Controllers
{
    public class CrudApiController : ApiController
    {
        WebApiCrudDbEntities db = new WebApiCrudDbEntities();
        public IHttpActionResult GetEmployees()
        {
            List<Employee> list = db.Employees.ToList();
            return Ok(list);
        }
    }
}
