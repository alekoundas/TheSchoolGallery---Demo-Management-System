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
    public class PaintingController : ApiController
    {
        private GalleryDbContext db = new GalleryDbContext();

        // GET: api/Painting
        public IQueryable<Painting> GetPaintings()
        {
            return db.PaintingsDb;
        }

        // GET: api/Painting/5
        [ResponseType(typeof(Painting))]
        public IHttpActionResult GetPainting(int id)
        {
            Painting painting = db.PaintingsDb.Find(id);
            if (painting == null)
            {
                return NotFound();
            }

            return Ok(painting);
        }

        // PUT: api/Painting/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPainting(int id, Painting painting)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != painting.PaintingId)
            {
                return BadRequest();
            }

            db.Entry(painting).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaintingExists(id))
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

        // POST: api/Painting
        [ResponseType(typeof(Painting))]
        public IHttpActionResult PostPainting(Painting painting)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PaintingsDb.Add(painting);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = painting.PaintingId }, painting);
        }

        // DELETE: api/Painting/5
        [ResponseType(typeof(Painting))]
        public IHttpActionResult DeletePainting(int id)
        {
            Painting painting = db.PaintingsDb.Find(id);
            if (painting == null)
            {
                return NotFound();
            }

            db.PaintingsDb.Remove(painting);
            db.SaveChanges();

            return Ok(painting);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PaintingExists(int id)
        {
            return db.PaintingsDb.Count(e => e.PaintingId == id) > 0;
        }
    }
}