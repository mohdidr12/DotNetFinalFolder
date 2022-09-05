using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_Real.Models;

namespace MVC_Real.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()

        {
            string url = "https://localhost:44327/All%20details";
            string response = " ";
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Content-type:application/json");
                webClient.Headers.Add("Accept:application/json");

                response = webClient.DownloadString(url);

            }
            var file = JsonConvert.DeserializeObject<List<Employee>>(response);
            return View(file);
        }
        [HttpPost]
        public ActionResult Create(Employee emp)

        {
            string url = "https://localhost:44327/Insert_emp";
            string response = " ";
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Content-type:application/json");
                webClient.Headers.Add("Accept:application/json");

                response = webClient.UploadString(url, JsonConvert.SerializeObject(emp));

            }

            return RedirectToAction("Index");
        }

        public ActionResult Create()

        {


            return View();
        }
    }
}