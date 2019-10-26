﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web_DomainClasses.Entities.School;
using Web_DomainClasses.ViewModels;
using Web_Front.Models;
using Web_Services.ApiMapping;

namespace Web_Front.Controllers
{
    public class ClassroomController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        ClassroomApiService ServiceClassroom = new ClassroomApiService();
        SchoolApiService ServiceSchool = new SchoolApiService();
        TeacherApiService ServiceTeacher = new TeacherApiService();

        // GET: Classroom
        public ActionResult Index()
        {
            return View(ServiceClassroom.GetClassrooms());
        }

        // GET: Classroom/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Classroom classroom = ServiceClassroom.GetClassroom(id);
            if (classroom == null)
            {
                return HttpNotFound();
            }
            return View(classroom);
        }

        // GET: Classroom/Create
        public ActionResult Create()
        {
            ClassroomCreateVM ViewModel = new ClassroomCreateVM();
            ViewModel.Schools = ServiceSchool.GetSchools();
            ViewModel.Teachers = ServiceTeacher.GetTeachers();
            return View(ViewModel);
        }

        // POST: Classroom/Create       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClassroomCreateVM ViewModel)
        {
            if (ModelState.IsValid)
            {
                ViewModel.Classroom.School = ServiceSchool.GetSchool(ViewModel.SelectedSchoolID); 
                ViewModel.Classroom.Teacher = ServiceTeacher.GetTeacher(ViewModel.SelectedTeacherID); 
                ServiceClassroom.CreateClassroom(ViewModel.Classroom);
                return RedirectToAction("Index");
            }
            ViewModel.Schools = ServiceSchool.GetSchools();
            return View(ViewModel.Classroom);
        }

        // GET: Classroom/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Classroom classroom = ServiceClassroom.GetClassroom(id);
            if (classroom == null)
            {
                return HttpNotFound();
            }
            return View(classroom);
        }

        // POST: Classroom/Edit/5       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ClassroomId,Image,Name,Description")] Classroom classroom)
        {
            if (ModelState.IsValid)
            {
                ServiceClassroom.EditClassroom(classroom);
                return RedirectToAction("Index");
            }
            return View(classroom);
        }

        // GET: Classroom/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Classroom classroom = ServiceClassroom.GetClassroom(id);
            if (classroom == null)
            {
                return HttpNotFound();
            }
            return View(classroom);
        }

        // POST: Classroom/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ServiceClassroom.DeleteClassroom(id);
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
