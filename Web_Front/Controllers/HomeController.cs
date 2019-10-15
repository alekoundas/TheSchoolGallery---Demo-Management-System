using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Entities;
using Web_Entities.Avatar;

namespace Web_Front.Controllers
{
    public class HomeController : Controller
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
            object JsonObj = JsonConvert.DeserializeObject<dynamic>(response);
            ViewBag.Message = JsonObj;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
    class Teacher
    {
        public int TeacherId { get; set; }


        public string FirstName { get; set; }

        public string LastName { get; set; }

        // Has one Avatar ---------------------------------->>
        public Avatar Avatar { get; set; }

        // Has one Class ----------------------------------->>

        public ICollection<Classroom> Classroom { get; set; }
    }

    class Results
    {
        [JsonProperty("jobcodes")]
        public Dictionary<string, JobCode> JobCodes { get; set; }
    }

    class JobCode
    {
        [JsonProperty("_status_code")]
        public string StatusCode { get; set; }
        [JsonProperty("_status_message")]
        public string StatusMessage { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}