using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using RajDeepSinghApi.Models;
using Newtonsoft.Json;

namespace RajDeepMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
           using(WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Content-type:application/json");
                webClient.Headers.Add("Accept:application/json");
                string response = webClient.DownloadString("https://localhost:44344/api/Recharge");
                var res = JsonConvert.DeserializeObject<IList<RechargeModel>>(response);
                return View(res);
            }

           
        }
    }
}