using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_DomainClasses.Entities.Avatar;

namespace Web_Services.ApiMapping.Avatars
{
    public class BodyApiService
    {
        const string Url = "https://localhost:44300/api/Avatar/Body";

        public List<AvatarBody> GetBodys()
        {
            RestClient client = new RestClient(Url);
            RestRequest request = new RestRequest(Method.GET);
            var response = client.Execute(request).Content;
            List<AvatarBody> JsonObj = JsonConvert.DeserializeObject<List<AvatarBody>>(response);

            return JsonObj;
        }

        public AvatarBody GetBody(int? Id)
        {
            RestClient client = new RestClient(Url + "/" + Id);
            RestRequest request = new RestRequest(Method.GET);
            var response = client.Execute(request).Content;
            AvatarBody JsonObj = JsonConvert.DeserializeObject<AvatarBody>(response);

            return JsonObj;
        }
    }
}
