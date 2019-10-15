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

        // GET: api/Avatars
        public IQueryable<Avatar> GetAvatarDb()
        {

            return db.AvatarDb.Include(x => x.Backgrounds).Include(y => y.Hairs).Include(z => z.Bodys).Include(a => a.Clothes);
        }

        // GET: api/Avatars/5
        [ResponseType(typeof(Avatar))]
        public IHttpActionResult GetAvatar(int id)
        {
            Avatar avatar = db.AvatarDb.Where(w => w.AvatarId == id).Include(x => x.Backgrounds).Include(y => y.Hairs).Include(z => z.Bodys).Include(a => a.Clothes).FirstOrDefault();
            if (avatar == null)
            {
                return NotFound();
            }

            return Ok(avatar);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AvatarExists(int id)
        {
            return db.AvatarDb.Count(e => e.AvatarId == id) > 0;
        }
    }
}