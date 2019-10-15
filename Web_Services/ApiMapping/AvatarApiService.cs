using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_DomainClasses.Entities.Avatar;
using Web_DomainClasses.Entities.School;

namespace Web_Services.ApiMapping
{
    public  class AvatarApiService
    {
        const string Url = "https://localhost:44300/api/Avatar";
        public  Avatar GetAvatar()
        {
            RestClient client = new RestClient(Url);
            RestRequest request = new RestRequest(Method.GET);
            var response = client.Execute(request).Content;
            Avatar JsonObj = JsonConvert.DeserializeObject<Avatar>(response);
          

            return JsonObj;
        }
    }
}
