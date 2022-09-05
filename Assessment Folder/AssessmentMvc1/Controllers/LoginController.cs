using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssessmentMvc1.Models;
using System.Net;
using Newtonsoft.Json;

namespace AssessmentMvc1.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Create()
        {
            return View();

        }
        
        [HttpPost]
        public ActionResult Create(SignIn tb)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Content-type:application/Json");
                webClient.Headers.Add("Accept:application/Json");
                string res = webClient.UploadString("https://localhost:44301/SignInUser", "Post", JsonConvert.SerializeObject(tb));
                return RedirectToAction("/Home/Index");

            }
        }
    }
}