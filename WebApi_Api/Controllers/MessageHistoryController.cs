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
using WebApi_Entities.SignalR;

namespace WebApi_Api.Controllers
{
    public class MessageHistoryController : ApiController
    {
        private GalleryDbContext db = new GalleryDbContext();

        // GET: api/MessageHistory
        public IQueryable<MessageHistory> GetMessageHistoryDb()
        {
            return db.MessageHistoryDb;
        }

            

        // POST: api/MessageHistory
        [ResponseType(typeof(MessageHistory))]
        public IHttpActionResult PostMessageHistory(MessageHistory messageHistory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.MessageHistoryDb.Add(messageHistory);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = messageHistory.MessageHistoryId }, messageHistory);
        }




        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MessageHistoryExists(int id)
        {
            return db.MessageHistoryDb.Count(e => e.MessageHistoryId == id) > 0;
        }
    }
}