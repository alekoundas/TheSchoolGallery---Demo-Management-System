using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web_DomainClasses.Entities.Avatar;
using Web_DomainClasses.ViewModels;
using Web_Front.Models;
using Web_Services.ApiMapping.Avatars;

namespace Web_Front.Controllers
{
    public class AvatarController : Controller
    {
        AvatarApiService ServiceAvatar = new AvatarApiService();
        BackgroundApiService ServiceBackground = new BackgroundApiService();
        HairApiService ServiceHair = new HairApiService();
        BodyApiService ServiceBody = new BodyApiService();
        ClothingApiService ServiceClothing = new ClothingApiService();

        // GET: Avatar
        public ActionResult Index()
        {
            return View(ServiceAvatar.GetAvatars());
        }

        // GET: Avatar/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Avatar avatar = ServiceAvatar.GetAvatar(id);
            if (avatar == null)
            {
                return HttpNotFound();
            }
            return View(avatar);
        }



        // GET: Avatar/Create

        public ActionResult Create()
        {
            AvatarCreateVM ViewModel = new AvatarCreateVM();

            ViewModel.AvatarBackgrounds = ServiceBackground.GetBackgrounds();
            ViewModel.AvatarHairs = ServiceHair.GetHairs();
            ViewModel.AvatarBodys = ServiceBody.GetBodys();
            ViewModel.AvatarClothings = ServiceClothing.GetClothings();
            return View(ViewModel);
        }



        // POST: Avatar/Create
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AvatarCreateVM ViewModel)
        {
            if (ModelState.IsValid)
            {
                ViewModel.Avatar = new Avatar();
                ViewModel.Avatar.BackgroundFK = ViewModel.SelectedBackgroundID;
                ViewModel.Avatar.HairFK = ViewModel.SelectedHairID;
                ViewModel.Avatar.BodyFK = ViewModel.SelectedBodyID;
                ViewModel.Avatar.ClothingFK = ViewModel.SelectedClothingID;


                ServiceAvatar.CreateAvatar(ViewModel.Avatar);
                return View(ServiceAvatar.GetAvatars());
            }
            ViewModel.AvatarBackgrounds = ServiceBackground.GetBackgrounds();
            ViewModel.AvatarHairs = ServiceHair.GetHairs();
            ViewModel.AvatarBodys = ServiceBody.GetBodys();
            ViewModel.AvatarClothings = ServiceClothing.GetClothings();
            return View(ServiceAvatar.GetAvatars());
        }

        // GET: Avatar/Edit/5
        public ActionResult Edit(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //Avatar avatar = db.Avatars.Find(id);
            //if (avatar == null)
            //{
            //    return HttpNotFound();
            //}
            //ViewBag.AvatarId = new SelectList(db.AvatarBackgrounds, "AvatarBackgroundId", "ImageUrl", avatar.AvatarId);
            //ViewBag.AvatarId = new SelectList(db.AvatarBodies, "AvatarBodyId", "ImageUrl", avatar.AvatarId);
            //ViewBag.AvatarId = new SelectList(db.AvatarClothes, "AvatarClothesId", "ImageUrl", avatar.AvatarId);
            //ViewBag.AvatarId = new SelectList(db.AvatarHairs, "AvatarHairId", "ImageUrl", avatar.AvatarId);
            return View(/*avatar*/);
        }

        // POST: Avatar/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AvatarId,Title")] Avatar avatar)
        {
            //if (ModelState.IsValid)
            //{
            //    db.Entry(avatar).State = EntityState.Modified;
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            //ViewBag.AvatarId = new SelectList(db.AvatarBackgrounds, "AvatarBackgroundId", "ImageUrl", avatar.AvatarId);
            //ViewBag.AvatarId = new SelectList(db.AvatarBodies, "AvatarBodyId", "ImageUrl", avatar.AvatarId);
            //ViewBag.AvatarId = new SelectList(db.AvatarClothes, "AvatarClothesId", "ImageUrl", avatar.AvatarId);
            //ViewBag.AvatarId = new SelectList(db.AvatarHairs, "AvatarHairId", "ImageUrl", avatar.AvatarId);
            return View(/*avatar*/);
        }

        // GET: Avatar/Delete/5
        public ActionResult Delete(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //Avatar avatar = db.Avatars.Find(id);
            //if (avatar == null)
            //{
            //    return HttpNotFound();
            //}
            return View(/*avatar*/);
        }

        // POST: Avatar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Avatar avatar = db.Avatars.Find(id);
            //db.Avatars.Remove(avatar);
            //db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
