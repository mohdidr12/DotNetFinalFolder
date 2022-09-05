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
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Contet-type:application/Json");
                webClient.Headers.Add("Accept:application/Json");
                string res = webClient.DownloadString("https://localhost:44301/DisplayData");
                var list = JsonConvert.DeserializeObject<List<SignUpPage>>(res);
                ViewBag.Message = "All Registered Users";
                return View(list);
            }

        }
        public ActionResult Insert()
        {
            ViewBag.Msg = "Registration Page";
            return View();
        }
        [HttpPost]
        public ActionResult Insert(SignUpPage std)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Content-type:application/Json");
                webClient.Headers.Add("Accept:application/Json");
                webClient.UploadString("https://localhost:44301/CreatePage", JsonConvert.SerializeObject(std));
                return RedirectToAction("Index");

            }

        }




    }
}