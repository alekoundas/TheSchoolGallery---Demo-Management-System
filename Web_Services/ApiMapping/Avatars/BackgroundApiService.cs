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
    public class BackgroundApiService
    {
        const string Url = "https://localhost:44300/api/Avatar/Background";

        public List<AvatarBackground> GetBackgrounds()
        {
            RestClient client = new RestClient(Url);
            RestRequest request = new RestRequest(Method.GET);
            var response = client.Execute(request).Content;
            List<AvatarBackground> JsonObj = JsonConvert.DeserializeObject<List<AvatarBackground>>(response);

            return JsonObj;
        }

        public AvatarBackground GetBackground(int? Id)
        {
            RestClient client = new RestClient(Url + "/" + Id);
            RestRequest request = new RestRequest(Method.GET);
            var response = client.Execute(request).Content;
            AvatarBackground JsonObj = JsonConvert.DeserializeObject<AvatarBackground>(response);

            return JsonObj;
        }
    }
}
