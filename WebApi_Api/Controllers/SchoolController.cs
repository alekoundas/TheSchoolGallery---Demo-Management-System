using RefactorThis.GraphDiff;
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
using WebApi_Database;

using WebApi_Entities.School;

namespace WebApi_Api.Controllers
{
    public class SchoolController : ApiController
    {
        private GalleryDbContext db = new GalleryDbContext();

        // GET: api/School
        public IQueryable<School> GetSchools()
        {
            return db.SchoolsDb
                .Include(a => a.Classroom.Select(b => b.Students.Select(c => c.Paintings)))
                .Include(d => d.Classroom.Select(e => e.Students.Select(f => f.Avatar)))
                .Include(g => g.Classroom.Select(e => e.Teacher))
                ;
        }

        // GET: api/School/5
        [ResponseType(typeof(School))]
        public IHttpActionResult GetSchool(int id)
        {
            School school = db.SchoolsDb.Where(w => w.SchoolId == id)
                .Include(a => a.Classroom.Select(b => b.Students.Select(c => c.Paintings)))
                .Include(d => d.Classroom.Select(e => e.Students.Select(f => f.Avatar)))
                .Include(g => g.Classroom.Select(e => e.Teacher))
                .FirstOrDefault();
            if (school == null)
            {
                return NotFound();
            }

            return Ok(school);
        }

        // PUT: api/School/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSchool(int id, School school)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != school.SchoolId)
            {
                return BadRequest();
            }

            db.Entry(school).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SchoolExists(id))
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

        // POST: api/School
        [ResponseType(typeof(School))]
        public IHttpActionResult PostSchool(School school)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.UpdateGraph(school);

            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = school.SchoolId }, school);
        }

        // DELETE: api/School/5
        [ResponseType(typeof(School))]
        public IHttpActionResult DeleteSchool(int id)
        {
            School school = db.SchoolsDb.Find(id);
            if (school == null)
            {
                return NotFound();
            }

            db.SchoolsDb.Remove(school);
            db.SaveChanges();

            return Ok(school);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SchoolExists(int id)
        {
            return db.SchoolsDb.Count(e => e.SchoolId == id) > 0;
        }
    }
}