using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Configuration;
using Web_DomainClasses.Entities.Avatar;

namespace Web_Services.ApiMapping.Avatars
{
    public class HairApiService
    {
        private string Url = ConfigurationManager.AppSettings["WebApiHost"] + "/api/Avatar/Hair";

        public List<AvatarHair> GetHairs()
        {
            RestClient client = new RestClient(Url);
            RestRequest request = new RestRequest(Method.GET);
            var response = client.Execute(request).Content;
            List<AvatarHair> JsonObj = JsonConvert.DeserializeObject<List<AvatarHair>>(response);

            return JsonObj;
        }

        public AvatarHair GetHair(int? Id)
        {
            RestClient client = new RestClient(Url + "/" + Id);
            RestRequest request = new RestRequest(Method.GET);
            var response = client.Execute(request).Content;
            AvatarHair JsonObj = JsonConvert.DeserializeObject<AvatarHair>(response);

            return JsonObj;
        }
    }
}
