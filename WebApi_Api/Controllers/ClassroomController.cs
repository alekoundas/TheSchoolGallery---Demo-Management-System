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
using WebApi_Entities;

namespace WebApi_Api.Controllers
{
    public class ClassroomController : ApiController
    {
        private GalleryDbContext db = new GalleryDbContext();

        // GET: api/Classroom
        public IQueryable<Classroom> GetClassrooms()
        {
            return db.Classrooms.Include(x=>x.School).Include(y=>y.Teacher).Include(z=>z.Students);
        }

        // GET: api/Classroom/5
        [ResponseType(typeof(Classroom))]
        public IHttpActionResult GetClassroom(int id)
        {
            Classroom classroom = db.Classrooms.Where(w=>w.ClassroomId == id).Include(x => x.School).Include(y => y.Teacher).Include(z => z.Students).FirstOrDefault();
            if (classroom == null)
            {
                return NotFound();
            }

            return Ok(classroom);
        }

        // PUT: api/Classroom/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutClassroom(int id, Classroom classroom)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != classroom.ClassroomId)
            {
                return BadRequest();
            }

            db.Entry(classroom).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassroomExists(id))
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

        // POST: api/Classroom
        [ResponseType(typeof(Classroom))]
        public IHttpActionResult PostClassroom(Classroom classroom)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Classrooms.Add(classroom);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = classroom.ClassroomId }, classroom);
        }

        // DELETE: api/Classroom/5
        [ResponseType(typeof(Classroom))]
        public IHttpActionResult DeleteClassroom(int id)
        {
            Classroom classroom = db.Classrooms.Find(id);
            if (classroom == null)
            {
                return NotFound();
            }

            db.Classrooms.Remove(classroom);
            db.SaveChanges();

            return Ok(classroom);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClassroomExists(int id)
        {
            return db.Classrooms.Count(e => e.ClassroomId == id) > 0;
        }
    }
}