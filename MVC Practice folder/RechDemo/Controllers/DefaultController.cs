using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RechDemo.Models;
using System.Data.Entity;

namespace RechDemo.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        aspDbEntities db = new aspDbEntities();

        // GET: Recharge
        public ActionResult Index()
        {

            return View(db.RechargeTableDbs.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(RechargeTableDb tb)
        {
            db.RechargeTableDbs.Add(tb);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var row = db.RechargeTableDbs.Where(model => model.Id == id).FirstOrDefault();
            return View(row);

        }
        [HttpPost]
        public ActionResult Edit(RechargeTableDb tb)
        {

            db.Entry(tb).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var studentRow = db.RechargeTableDbs.Where(model => model.Id == id).FirstOrDefault();
            return View(studentRow);
        }
        [HttpPost]
        public ActionResult Delete(RechargeTableDb tb)
        {

            db.Entry(tb).State = EntityState.Deleted;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}