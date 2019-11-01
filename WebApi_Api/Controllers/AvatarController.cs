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
using WebApi_Entities.Avatar;

namespace WebApi_Api.Controllers
{
    public class AvatarController : ApiController
    {
        private GalleryDbContext db = new GalleryDbContext();


        /////////////////////////////////////////////////////////////////////////////////////
        ///                                                                               ///
        ///                             Avatar                                            ///
        ///                                                                               ///
        ///////////////////////////////////////////////////////////////////////////////////// 
        // GET: api/Avatar
        public IQueryable<Avatar> GetAvatar()
        {

            return db.AvatarDb
                .Include(b => b.Background)
                .Include(c => c.Hair)
                .Include(d => d.Body)
                .Include(e => e.Clothing)
                .Include(f => f.Students.Select(g=>g.Classroom.School))
                .Include(h => h.Students.Select(i=>i.Paintings));
        }

        // GET: api/Avatar/5
        [ResponseType(typeof(Avatar))]
        public IHttpActionResult GetAvatar(int id)
        {

            Avatar avatar = db.AvatarDb
                .Where(a => a.AvatarId == id)
                .Include(b => b.Background)
                .Include(c => c.Hair)
                .Include(d => d.Body)
                .Include(e => e.Clothing)
                .Include(f => f.Students.Select(g => g.Classroom.School))
                .Include(h => h.Students.Select(i => i.Paintings))
                .FirstOrDefault();



            if (avatar == null)
            {
                return NotFound();
            }

            return Ok(avatar);
        }

        // POST: api/Avatar
        [ResponseType(typeof(Avatar))]
        public IHttpActionResult PostClassroom(Avatar Avatar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Avatar.Hair = null;
            Avatar.Body = null;
            Avatar.Clothing = null;
            db.AvatarDb.Add(Avatar);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = Avatar.AvatarId }, Avatar);
        }




        /////////////////////////////////////////////////////////////////////////////////////
        ///                                                                               ///
        ///                             Background                                        ///
        ///                                                                               ///
        ///////////////////////////////////////////////////////////////////////////////////// 


        // GET: api/Avatar/Background
        [Route("api/Avatar/Background")]
        public IQueryable<AvatarBackground> GetBackground()
        {
            return db.AvatarBackgroundDb;
        }

        // GET: api/Avatar/Background/5
        [Route("api/Avatar/Background/{id}")]
        [ResponseType(typeof(AvatarBackground))]
        public IHttpActionResult GetBackground(int id)
        {
            AvatarBackground Background = db.AvatarBackgroundDb.Where(w => w.AvatarBackgroundId == id).FirstOrDefault();
            if (Background == null)
            {
                return NotFound();
            }

            return Ok(Background);
        }


        /////////////////////////////////////////////////////////////////////////////////////
        ///                                                                               ///
        ///                             Hair                                              ///
        ///                                                                               ///
        ///////////////////////////////////////////////////////////////////////////////////// 



        // GET: api/Avatar/Hair
        [Route("api/Avatar/Hair")]
        public IQueryable<AvatarHair> GetHair()
        {
            return db.AvatarHairDb;
        }

        // GET: api/Avatar/Hair/5
        [Route("api/Avatar/Hair/{id}")]
        [ResponseType(typeof(AvatarHair))]
        public IHttpActionResult GetHair(int id)
        {
            AvatarHair Hair = db.AvatarHairDb.Where(w => w.AvatarHairId == id).FirstOrDefault();
            if (Hair == null)
            {
                return NotFound();
            }

            return Ok(Hair);
        }


        /////////////////////////////////////////////////////////////////////////////////////
        ///                                                                               ///
        ///                             Body                                              ///
        ///                                                                               ///
        ///////////////////////////////////////////////////////////////////////////////////// 




        // GET: api/Avatar/Body
        [Route("api/Avatar/Body")]
        public IQueryable<AvatarBody> GetBody()
        {
            return db.AvatarBodyDb;
        }

        // GET: api/Avatar/Body/5
        [Route("api/Avatar/Body/{id}")]
        [ResponseType(typeof(AvatarBody))]
        public IHttpActionResult GetBody(int id)
        {
            AvatarBody Body = db.AvatarBodyDb.Where(w => w.AvatarBodyId == id).FirstOrDefault();
            if (Body == null)
            {
                return NotFound();
            }

            return Ok(Body);
        }



        /////////////////////////////////////////////////////////////////////////////////////
        ///                                                                               ///
        ///                             Clothes                                           ///
        ///                                                                               ///
        ///////////////////////////////////////////////////////////////////////////////////// 





        // GET: api/Avatar/Clothes
        [Route("api/Avatar/Clothes")]
        public IQueryable<AvatarClothing> GetClothes()
        {
            return db.AvatarClothingDb;
        }

        // GET: api/Avatar/Clothes/5
        [Route("api/Avatar/Clothes/{id}")]
        [ResponseType(typeof(AvatarClothing))]
        public IHttpActionResult GetClothes(int id)
        {
            AvatarClothing Clothes = db.AvatarClothingDb.Where(w => w.AvatarClothingId == id).FirstOrDefault();
            if (Clothes == null)
            {
                return NotFound();
            }

            return Ok(Clothes);
        }






        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}