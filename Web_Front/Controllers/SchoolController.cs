using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web_DomainClasses.Entities.GoogleMaps;
using Web_DomainClasses.Entities.School;
using Web_Front.Models;
using Web_Services.ApiMapping;

namespace Web_Front.Controllers
{
    [Authorize]
    public class SchoolController : MasterController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        SchoolApiService ServiceSchool = new SchoolApiService();

        // GET: School
        public ActionResult Index()
        {
            return View(ServiceSchool.GetSchools());
        }

        // GET: School/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            School school = ServiceSchool.GetSchool(id);
            if (school == null)
            {
                return HttpNotFound();
            }
            return View(school);
        }

        // GET: School/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: School/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SchoolId,Name,City,Adress,Tel,PlaceId")] School school)
        {
            if (ModelState.IsValid)
            {
                ServiceSchool.CreateSchool(school);
                return RedirectToAction("Index");
            }

            return View(school);
        }

        // GET: School/Edit/5
        [Authorize(Roles = "Admin, SchoolAdmin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            School school = ServiceSchool.GetSchool(id);
            if (school == null)
            {
                return HttpNotFound();
            }
            return View(school);
        }

        // POST: School/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, SchoolAdmin")]
        public ActionResult Edit([Bind(Include = "SchoolId,Name,City,Adress,Tel")] School school)
        {
            if (ModelState.IsValid)
            {
                ServiceSchool.EditSchool(school);
                return RedirectToAction("Index");
            }
            return View(school);
        }

        // GET: School/Delete/5
        [Authorize(Roles = "Admin, SchoolAdmin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            School school = ServiceSchool.GetSchool(id);
            if (school == null)
            {
                return HttpNotFound();
            }
            return View(school);
        }

        // POST: School/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, SchoolAdmin")]
        public ActionResult DeleteConfirmed(int id)
        {
            ServiceSchool.DeleteSchool(id);
            return RedirectToAction("Index");
        }




        /// <summary>
        /// Retrives all schools and extract Place_id prop to a list
        /// </summary>
        /// <returns>JSON List of Place_id Of every school</returns>
        [HttpGet]
        public JsonResult GetPlace_ids()
        {

            MapMarker marker = new MapMarker();
            marker.Place_IDs = ServiceSchool.GetSchools().Select(x => x.PlaceId).ToList();
            marker.Titles = ServiceSchool.GetSchools().Select(x => x.Name).ToList();

            return Json(marker, JsonRequestBehavior.AllowGet);
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
