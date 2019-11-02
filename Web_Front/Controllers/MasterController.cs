using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Web_DomainClasses;
using Web_DomainClasses.Entities;
using Web_DomainClasses.Entities.Avatar;
using Web_DomainClasses.Entities.SignalR;
using Web_DomainClasses.Entities.School;
using System.Web.Mvc;
using Web_Services.ApiMapping;
using System.Net;

namespace Web_Front.Controllers
{
    [Authorize]
    //Every Controller Inherits Controller and SignalR Logic From MasterController
    public class MasterController : Controller
    {
        MessageApiService MessageServ = new MessageApiService();
        //SignalR Required To Return Chat
        public ActionResult Chat()
        {
            return View(MessageServ.GetMessageHistorys());
        }



        //Save msg To API DB
        [HttpGet]
        public ActionResult SaveMessage(string username, string msg)
        {

            MessageServ.CreateMessageHistory(new MessageHistory { Name= username, Message= msg });
            return Json(new { success = true, responseText = "Your message successfuly sent!" }, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        [AllowAnonymous]
        public ActionResult GetMessage()
        {

            return Json(MessageServ.GetMessageHistorys());

        }

    }
}