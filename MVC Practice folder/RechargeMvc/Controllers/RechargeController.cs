using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RechargeMvc.Models;
using System.Data.Entity;

namespace RechargeMvc.Controllers
{
    public class RechargeController : Controller
    {
        aspDbEntities db = new aspDbEntities();
        // GET: Recharge
        public ActionResult Index()
        {

            return View(db.RechargeTbs.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(RechargeTb tb)
        {
            db.RechargeTbs.Add(tb);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var row = db.RechargeTbs.Where(model => model.Id == id).FirstOrDefault();
            return View(row);

        }
        [HttpPost]
        public ActionResult Edit(RechargeTb tb)
        {

            db.Entry(tb).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var studentRow = db.RechargeTbs.Where(model => model.Id == id).FirstOrDefault();
            return View(studentRow);
        }
        [HttpPost]
        public ActionResult Delete(RechargeTb tb)
        {

            db.Entry(tb).State = EntityState.Deleted;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
