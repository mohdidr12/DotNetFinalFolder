using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using callApi.Models;

namespace SupporterClass.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            string url = "https://localhost"
            using(WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Content-type:application/json");
                webClient.Headers.Add("Accept:application/json");
                string response = webClient.DownloadString("")

            }
            return View();
        }
    }
}