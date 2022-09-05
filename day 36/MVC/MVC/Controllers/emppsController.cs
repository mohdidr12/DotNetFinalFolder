using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MVC.Models;

namespace MVC.Controllers
{
    public class emppsController : ApiController
    {
        private GL_Database1Entities1 db = new GL_Database1Entities1();

        // GET: api/empps
        [HttpGet]
        [Route("All details")]
        public IQueryable<empp> Getempps()
        {
            return db.empps;
        }

        [HttpPost]
        [Route("Insert_emp")]
        public string InsertEmp(empp em)
        {
            db.empps.Add(em);
            db.SaveChanges();
            return ("sucess");
        }
        // GET: api/empps/5
        [ResponseType(typeof(empp))]
        public IHttpActionResult Getempp(int id)
        {
            empp empp = db.empps.Find(id);
            if (empp == null)
            {
                return NotFound();
            }

            return Ok(empp);
        }

        // PUT: api/empps/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putempp(int id, empp empp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != empp.Id)
            {
                return BadRequest();
            }

            db.Entry(empp).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!emppExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/empps
        [ResponseType(typeof(empp))]
        public IHttpActionResult Postempp(empp empp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.empps.Add(empp);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (emppExists(empp.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = empp.Id }, empp);
        }

        // DELETE: api/empps/5
        [ResponseType(typeof(empp))]
        public IHttpActionResult Deleteempp(int id)
        {
            empp empp = db.empps.Find(id);
            if (empp == null)
            {
                return NotFound();
            }

            db.empps.Remove(empp);
            db.SaveChanges();

            return Ok(empp);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool emppExists(int id)
        {
            return db.empps.Count(e => e.Id == id) > 0;
        }
    }
}