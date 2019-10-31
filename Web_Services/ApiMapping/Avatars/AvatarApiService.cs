using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using Web_DomainClasses.Entities.Avatar;
using Web_DomainClasses.ViewModels;

namespace Web_Services.ApiMapping.Avatars
{
    public  class AvatarApiService
    {
        const string Url = "https://localhost:44300/api/Avatar";
        public List<Avatar> GetAvatars()
        {
            RestClient client = new RestClient(Url);
            RestRequest request = new RestRequest(Method.GET);
            var response = client.Execute(request).Content;
            List<Avatar> JsonObj = JsonConvert.DeserializeObject<List<Avatar>>(response);
          

            return JsonObj;
        }

        public Avatar GetAvatar(int? Id)
        {
            RestClient client = new RestClient(Url + "/"+Id);
            RestRequest request = new RestRequest(Method.GET);
            var response = client.Execute(request).Content;
            Avatar JsonObj = JsonConvert.DeserializeObject<Avatar>(response);

            return JsonObj;
        }



        //               CREATE Avatar                 \\
        //       Method:POST  -->  /api/Avatar          \\

        public void CreateAvatar(Avatar Avatar)
        {
            RestClient client = new RestClient(Url + "/" + Avatar.AvatarId);
            RestRequest request = new RestRequest(Method.POST);
            request.AddJsonBody(Avatar);
            var response = client.Execute(request).Content;

            Avatar Avatars = JsonConvert.DeserializeObject<Avatar>(response);
        }





    }
}
