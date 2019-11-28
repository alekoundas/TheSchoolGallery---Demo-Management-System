using Newtonsoft.Json;
using PagedList;
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
    [Authorize]
    public class ClassroomController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        ClassroomApiService ServiceClassroom = new ClassroomApiService();
        SchoolApiService ServiceSchool = new SchoolApiService();
        TeacherApiService ServiceTeacher = new TeacherApiService();

        // GET: Classroom
        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            // SORTING ---------------------------------------------------------------------------->>
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.CurrentSort = sortOrder;

            var classrooms = from cls in ServiceClassroom.GetClassrooms()
                           select cls;

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
                classrooms = classrooms.Where(st => (st.Name.Contains(searchString)));
            }

            // SORTING ---------------------------------------------------------------------------->>
            switch (sortOrder)
            {
                case "name_desc":
                    classrooms = classrooms.OrderByDescending(s => s.Name);
                    break;
                default:
                    classrooms = classrooms.OrderBy(s => s.Name);
                    break;
            }

            // Number of Pages -------------------------------------------------------------------->>
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(classrooms.ToPagedList(pageNumber, pageSize));

            // Palio return ------------------------------>>
            //return View(ServiceClassroom.GetClassrooms());
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
        [Authorize(Roles = "Admin, SchoolAdmin")]
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
        [Authorize(Roles = "Admin, SchoolAdmin")]
        public ActionResult Edit([Bind(Include = "ClassroomId,TeacherFK,SchoolFK,Image,Name,Description")] Classroom classroom)
        {
            if (ModelState.IsValid)
            {
                ServiceClassroom.EditClassroom(classroom);
                return RedirectToAction("Index");
            }
            return View(classroom);
        }

        // GET: Classroom/Delete/5
        [Authorize(Roles = "Admin, SchoolAdmin")]
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
        [Authorize(Roles = "Admin, SchoolAdmin")]
        public ActionResult DeleteConfirmed(int id)
        {
            ServiceClassroom.DeleteClassroom(id);
            return RedirectToAction("Index");
        }



        
        [HttpGet]
        public string GetPlace_ids()
        {

            //get or create WorkItem here
            var schools = ServiceSchool.GetSchools().Select(x=>x.PlaceId);


           
            return JsonConvert.SerializeObject(schools);
        }



        // GET: C#
        [AllowAnonymous]
        public ActionResult classSharp()
        {
            return View();
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
