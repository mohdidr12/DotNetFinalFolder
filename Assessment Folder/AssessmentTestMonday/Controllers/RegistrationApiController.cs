using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AssessmentTestMonday.Models;

namespace AssessmentTestMonday.Controllers
{
    public class RegistrationApiController : ApiController
    {
        WebApiCrudDbEntities db = new WebApiCrudDbEntities();

        [HttpGet]
        [Route("DisplayData")]
        public List<SignUpPage> GetStudentData()
        {
            var res = db.SignUpPages.ToList();
            return res;

        }


        [HttpPost]
        [Route("CreatePage")]
       public void PostRegistration(SignUpPage sp)
        {
            db.SignUpPages.Add(sp);
            db.SaveChanges();
        }
    }
}
