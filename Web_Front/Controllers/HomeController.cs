using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_DomainClasses;
using Web_DomainClasses.Entities;
using Web_DomainClasses.Entities.Avatar;
using Web_DomainClasses.Entities.School;

namespace Web_Front.Controllers
{
    public class HomeController : MasterController
    {

       



        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            string Url = "https://localhost:44300/api/Teacher";
            RestClient client = new RestClient(Url);
            RestRequest request = new RestRequest(Method.GET);
            var response = client.Execute(request).Content;
            object JsonObj = JsonConvert.DeserializeObject<List<Teacher>>(response);
            ViewBag.Message = JsonObj;
            Trace.WriteLine(JsonObj);
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}