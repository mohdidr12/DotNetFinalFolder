using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AssessmentTestMonday.Models;

namespace AssessmentTestMonday.Controllers
{
    public class LogInApiController : ApiController
    {
        WebApiCrudDbEntitiesSignIn db = new WebApiCrudDbEntitiesSignIn();
        [HttpPost]
        [Route("SignInUser")]
        public Response employeeLogin(SignIn login)
        {
            var log = db.SignIns.Where(x => x.Username.Equals(login.Username) && x.Password.Equals(login.Password)).FirstOrDefault();

            if (log == null)

            {

                return new Response { Status = "Invalid", Message = "Invalid User." };

            }

            else
            {
                return new Response { Status = "Success", Message = "Login Successfully" };

            }
        }


    }
}
