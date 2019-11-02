using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
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
    [Authorize]
    public class StudentController : MasterController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        StudentApiService StudentServ = new StudentApiService();
        ClassroomApiService ServiceClassroom = new ClassroomApiService();
        SchoolApiService ServiceSchool = new SchoolApiService();

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
            ViewModel.Schools = ServiceSchool.GetSchools();
            ViewModel.Classrooms = ServiceClassroom.GetClassrooms();

            var a = ServiceSchool.GetSchools();
            return View(ViewModel);
        }

        /// <summary>
        /// Returns Partial View Of A List Of Classrooms Based On Selected School 
        /// </summary>
        /// <param name="SchoolID"></param>
        /// <returns>List<Classroom></returns>
        public PartialViewResult UpdateDropDownList(int? SchoolID)
        {

            List<Classroom> ClassroomList = ServiceSchool.GetSchool(SchoolID).Classroom.ToList();

           
            //(PartialView Name, Database List)
            return PartialView("_CreateAjaxDropdown", ClassroomList);
        }






        // POST: Student/Create      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentCreateVM ViewModel)
        {
            if (ModelState.IsValid)
            {
               //We Need To Set Instance of School and Classroom at Student To be Created!
                ViewModel.Student.Classroom= ServiceClassroom.GetClassroom(ViewModel.SelectedClassroomID);
                ViewModel.Student.Classroom.School = ServiceSchool.GetSchool(ViewModel.SelectedSchoolID);
                //Create User
                StudentServ.CreateStudent(ViewModel.Student);
                return RedirectToAction("Index");
            }
            //Refill Lists
            ViewModel.Schools = ServiceSchool.GetSchools();
            ViewModel.Classrooms = ServiceClassroom.GetClassrooms();
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
        public ActionResult Edit([Bind(Include = "StudentId,AvatarFK,ClassroomFK,FirstName,LastName,Age")] Student student)
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
