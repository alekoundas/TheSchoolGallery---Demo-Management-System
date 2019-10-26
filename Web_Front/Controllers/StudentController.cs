using System;
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
    public class StudentController : MasterController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        StudentApiService StudentServ = new StudentApiService();
        ClassroomApiService ClassroomServ = new ClassroomApiService();
        SchoolApiService SchoolServ = new SchoolApiService();

        // GET: Student
        public ActionResult Index()
        {
            return View(StudentServ.GetStudents());
        }

        // GET: Student/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = StudentServ.GetStudent(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            StudentCreateVM ViewModel = new StudentCreateVM();
            ViewModel.Schools = SchoolServ.GetSchools();
            ViewModel.Classrooms = ClassroomServ.GetClassrooms();

            var a = SchoolServ.GetSchools();
            return View(ViewModel);
        }

        // POST: Student/Create      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentCreateVM ViewModel)
        {
            if (ModelState.IsValid)
            {
               //We Need To Set Instance of School and Classroom at Student To be Created!
                ViewModel.Student.Classroom= ClassroomServ.GetClassroom(ViewModel.SelectedClassroomID);
                ViewModel.Student.Classroom.School = SchoolServ.GetSchool(ViewModel.SelectedSchoolID);
                //Create User
                StudentServ.CreateStudent(ViewModel.Student);
                return RedirectToAction("Index");
            }
            //Refill Lists
            ViewModel.Schools = SchoolServ.GetSchools();
            ViewModel.Classrooms = ClassroomServ.GetClassrooms();
            return View(ViewModel);
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = StudentServ.GetStudent(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentId,FirstName,LastName,Age")] Student student)
        {
            if (ModelState.IsValid)
            {
                StudentServ.EditStudent(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = StudentServ.GetStudent(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentServ.DeleteStudent(id);
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
