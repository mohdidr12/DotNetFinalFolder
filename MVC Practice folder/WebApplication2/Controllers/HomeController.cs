using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;



namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            string url = "https://localhost:44395/AllRecharge";
            string response = "";
            using(WebClient webClient =  new WebClient())
            {
                webClient.Headers.Add("Content-type:application/json");
                webClient.Headers.Add("Accept:application/json");
                response = webClient.DownloadString(url);




            }
            var r = JsonConvert.Deserialize
            return View();
        }
    }
}