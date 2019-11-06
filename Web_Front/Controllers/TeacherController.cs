﻿using System;
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
    [Authorize(Roles = "Admin, SchoolAdmin")]
    public class TeacherController : MasterController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        TeacherApiService ServiceTeacher = new TeacherApiService();


        // GET: Teacher
        public ActionResult Index()
        {
            return View(ServiceTeacher.GetTeachers());
        }




        // GET: Teacher/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teacher teacher = ServiceTeacher.GetTeacher(id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            return View(teacher);
        }



        // GET: Teacher/Create
        public ActionResult Create()
        {

            return View();
        }



        // POST: Teacher/Create      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TeacherId,FirstName,LastName")] Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                ServiceTeacher.CreateTeacher(teacher);
                return RedirectToAction("Index");
            }

            return View(teacher);
        }

        // GET: Teacher/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teacher teacher = ServiceTeacher.GetTeacher(id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            return View(teacher);
        }

        // POST: Teacher/Edit/5       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TeacherId,FirstName,LastName")] Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                ServiceTeacher.EditTeacher(teacher);
                return RedirectToAction("Index");

            }
            return View(teacher);
        }

        // GET: Teacher/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teacher teacher = ServiceTeacher.GetTeacher(id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            return View(teacher);
        }

        // POST: Teacher/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ServiceTeacher.DeleteTeacher(id);
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
