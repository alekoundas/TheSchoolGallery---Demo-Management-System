﻿using PagedList;
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
        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            // SORTING ---------------------------------------------------------------------------->>
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "fname_desc" : "";
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "lname_desc" : "";
            ViewBag.CurrentSort = sortOrder;

            var students = from st in StudentServ.GetStudents()
                           select st;

            // PAGE NUMBERS ----------------------------------------------------------------------->>
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewBag.CurrentFilter = searchString;


            // FILTER --------------------------------------=-------------------------------------->>
            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(st => (st.FirstName.Contains(searchString)) || (st.LastName.Contains(searchString)));
            }

            // SORTING ---------------------------------------------------------------------------->>
            switch (sortOrder)
            {
                case "fname_desc":
                    students = students.OrderByDescending(s => s.FirstName);
                    break;
                case "lname_desc":
                    students = students.OrderByDescending(s => s.LastName);
                    break;
                default:
                    students = students.OrderBy(s => s.LastName);
                    break;
            }

            // Number of Pages -------------------------------------------------------------------->>
            int pageSize = 6;
            int pageNumber = (page ?? 1);
            return View(students.ToPagedList(pageNumber, pageSize));

            // Palio return ------------------------------>>
            //return View(StudentServ.GetStudents());
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

            List<Classroom> ClassroomList = ServiceSchool.GetSchool(SchoolID).Classrooms.ToList();


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
                ViewModel.Student.ClassroomFK = ViewModel.SelectedClassroomID;
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
        [Authorize(Roles = "Admin, SchoolAdmin")]
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
        [Authorize(Roles = "Admin, SchoolAdmin")]
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
        [Authorize(Roles = "Admin, SchoolAdmin")]
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
        [Authorize(Roles = "Admin, SchoolAdmin")]
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
