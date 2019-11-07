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
using WebApi_Services;

using WebApi_Entities.School;

namespace WebApi_Api.Controllers
{
    public class SchoolController : ApiController
    {
        private GalleryDbContext db = new GalleryDbContext();
        ServiceClearExtraData ServiceMaid = new ServiceClearExtraData();




        // GET: api/School
        public IQueryable<School> GetSchools()
        {
            IQueryable<School> schools =  db.SchoolsDb
                .Include(b => b.Classrooms.Select(c => c.Students.Select(d => d.Paintings)))
                .Include(e => e.Classrooms.Select(f => f.Students.Select(g => g.Avatar.Background)))
                .Include(h => h.Classrooms.Select(i => i.Students.Select(j => j.Avatar.Hair)))
                .Include(k => k.Classrooms.Select(l => l.Students.Select(m => m.Avatar.Body)))
                .Include(n => n.Classrooms.Select(o => o.Students.Select(p => p.Avatar.Clothing)))
                .Include(q => q.Classrooms.Select(r => r.Teacher)) ;

            ServiceMaid.CleanSchools(schools);

            return schools;
        }

        // GET: api/School/5
        [ResponseType(typeof(School))]
        public IHttpActionResult GetSchool(int id)
        {
            School school = db.SchoolsDb.Where(a => a.SchoolId == id)
                .Include(b => b.Classrooms.Select(c => c.Students.Select(d => d.Paintings)))
                .Include(e => e.Classrooms.Select(f => f.Students.Select(g => g.Avatar.Background)))
                .Include(h => h.Classrooms.Select(i => i.Students.Select(j => j.Avatar.Hair)))
                .Include(k => k.Classrooms.Select(l => l.Students.Select(m => m.Avatar.Body)))
                .Include(n => n.Classrooms.Select(o => o.Students.Select(p => p.Avatar.Clothing)))
                .Include(q => q.Classrooms.Select(r => r.Teacher))
                .FirstOrDefault();

            ServiceMaid.CleanSchool(school);





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