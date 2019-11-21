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
using WebApi_Entities.Avatar;
using WebApi_Entities.School;
using WebApi_Services;

namespace WebApi_Api.Controllers
{
    public class StudentController : ApiController
    {
        private GalleryDbContext db = new GalleryDbContext();
        ServiceClearExtraData ServiceMaid = new ServiceClearExtraData();
        // GET: api/Student
        public IQueryable<Student> GetStudentDb()
        {
            IQueryable<Student> students = db.StudentDb
                .Include(x => x.Avatar.Background)
                .Include(x => x.Avatar.Hair)
                .Include(x => x.Avatar.Body)
                .Include(x => x.Avatar.Clothing)
                .Include(y => y.Classroom.School)
                .Include(z => z.Paintings);

            ServiceMaid.CleanStudents(students);
            return students;
        }

        // GET: api/Student/5
        [ResponseType(typeof(Student))]
        public IHttpActionResult GetStudent(int id)
        {
            Student student = db.StudentDb
                .Where(w => w.StudentId == id)
                .Include(x => x.Avatar.Background)
                .Include(x => x.Avatar.Hair)
                .Include(x => x.Avatar.Body)
                .Include(x => x.Avatar.Clothing)
                .Include(y => y.Classroom.School)
                .Include(z => z.Paintings)
                .FirstOrDefault();

            if (student == null)
            {
                return NotFound();
            }
            ServiceMaid.CleanStudent(student);
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


            student.Classroom = null;
            //Initialise the avatar
            student.Avatar = new Avatar() { Background = new AvatarBackground(), Body = new AvatarBody(), Hair = new AvatarHair(), Clothing = new AvatarClothing() };


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