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
using WebApi_Entities;
using WebApi_Entities.School;

namespace WebApi_Api.Controllers
{
    public class StudentController : ApiController
    {
        private GalleryDbContext db = new GalleryDbContext();

        // GET: api/Student
        public IQueryable<Student> GetStudentDb()
        {
            return db.StudentDb.Include(x => x.Avatar).Include(y => y.Classroom).Include(z => z.Paintings);
        }

        // GET: api/Student/5
        [ResponseType(typeof(Student))]
        public IHttpActionResult GetStudent(int id)
        {
            Student student = db.StudentDb.Where(w => w.StudentId == id).Include(x => x.Avatar).Include(y => y.Classroom).Include(z => z.Paintings).FirstOrDefault() ;
            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        // PUT: api/Student/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutStudent(int id, Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != student.StudentId)
            {
                return BadRequest();
            }

            db.Entry(student).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(id))
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

        /// <summary>
        /// Makes Use Of GraphDiff Library in order to add Student Without Creating Dublicates
        /// in Database Based On Relations 
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        // POST: api/Student
        [ResponseType(typeof(Student))]
        public IHttpActionResult PostStudent(Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            student.ClassroomFK = student.Classroom.ClassroomId;
            student.Classroom = null;


            db.StudentDb.Add(student);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = student.StudentId }, student);
        }

        // DELETE: api/Student/5
        [ResponseType(typeof(Student))]
        public IHttpActionResult DeleteStudent(int id)
        {
            Student student = db.StudentDb.Find(id);
            if (student == null)
            {
                return NotFound();
            }

            db.StudentDb.Remove(student);
            db.SaveChanges();

            return Ok(student);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StudentExists(int id)
        {
            return db.StudentDb.Count(e => e.StudentId == id) > 0;
        }
    }
}