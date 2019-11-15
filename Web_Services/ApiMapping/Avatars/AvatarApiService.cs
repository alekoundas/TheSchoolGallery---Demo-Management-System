﻿using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Configuration;
using Web_DomainClasses.Entities.Avatar;
using Web_DomainClasses.ViewModels;

namespace Web_Services.ApiMapping.Avatars
{
    public  class AvatarApiService
    {
        private string Url = ConfigurationManager.AppSettings["WebApiHost"] +"/api/Avatar";
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


        }



        //                EDIT Avatar By ID                   \\
        //           Method:PUT  -->  /api/Avatar/id           \\
        public void EditAvatar(Avatar Avatar)
        {
            //Create Client
            RestClient client = new RestClient(Url + "/" + Avatar.AvatarId);

            //Build A Request For The Api    PUT
            RestRequest request = new RestRequest(Method.PUT);
            request.AddJsonBody(Avatar);

            //Execute Request
            var response = client.Execute(request).Content;           
        }

    }
}
