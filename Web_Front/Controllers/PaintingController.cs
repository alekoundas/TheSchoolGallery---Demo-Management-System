using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web_DomainClasses.Entities.School;
using Web_Front.Models;
using Web_Services.ApiMapping;

namespace Web_Front.Controllers
{
    [Authorize]
    public class PaintingController : MasterController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        PaintingApiService PaintingServ = new PaintingApiService();

        // GET: Painting
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View(PaintingServ.GetPaintings());
        }

        // GET: Painting/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Painting painting = PaintingServ.GetPainting(id);
            if (painting == null)
            {
                return HttpNotFound();
            }
            return View(painting);
        }

        // GET: Painting/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Painting/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PaintingId,ImageUrl,PaintingTitle")] Painting painting)
        {
            if (ModelState.IsValid)
            {
                PaintingServ.CreatePainting(painting);
                return RedirectToAction("Index");
            }

            return View(painting);
        }

        // GET: Painting/Edit/5
        [Authorize(Roles = "Admin, SchoolAdmin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Painting painting = PaintingServ.GetPainting(id);
            if (painting == null)
            {
                return HttpNotFound();
            }
            return View(painting);
        }

        // POST: Painting/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, SchoolAdmin")]
        public ActionResult Edit([Bind(Include = "PaintingId,ImageUrl,PaintingTitle")] Painting painting)
        {
            if (ModelState.IsValid)
            {
                PaintingServ.EditPainting(painting);
                return RedirectToAction("Index");
            }
            return View(painting);
        }

        // GET: Painting/Delete/5
        [Authorize(Roles = "Admin, SchoolAdmin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Painting painting = PaintingServ.GetPainting(id);
            if (painting == null)
            {
                return HttpNotFound();
            }
            return View(painting);
        }

        // POST: Painting/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, SchoolAdmin")]
        public ActionResult DeleteConfirmed(int id)
        {
            PaintingServ.DeletePainting(id);
            return RedirectToAction("Index");
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
