using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_DomainClasses.Entities.Avatar;

namespace Web_Services.ApiMapping.Avatars
{
    public class ClothingApiService
    {
        private string Url = ConfigurationManager.AppSettings["WebApiHost"] + "/api/Avatar/Clothes";

        public List<AvatarClothing> GetClothings()
        {
            RestClient client = new RestClient(Url);
            RestRequest request = new RestRequest(Method.GET);
            var response = client.Execute(request).Content;
            List<AvatarClothing> JsonObj = JsonConvert.DeserializeObject<List<AvatarClothing>>(response);

            return JsonObj;
        }

        public AvatarClothing GetClothing(int? Id)
        {
            RestClient client = new RestClient(Url + "/" + Id);
            RestRequest request = new RestRequest(Method.GET);
            var response = client.Execute(request).Content;
            AvatarClothing JsonObj = JsonConvert.DeserializeObject<AvatarClothing>(response);

            return JsonObj;
        }
    }
}
