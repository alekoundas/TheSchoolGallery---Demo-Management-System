using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Front.Models.reCAPTCHA;

namespace Web_Services.ApiMapping.Authentication
{
    public class RecaptchaApiService
    {
        //Constant Url To WebApi
        const string Url = "https://www.google.com/recaptcha/api/siteverify?";


        //              Method:POST                 \\
        public bool ValidateUserResponse(string recaptcha_response)
        {
            string secret = "secret=6Lcc_sEUAAAAAOlbrK_gK8DRI0TNYZmWMjpk-08Y";
            recaptcha_response = "response=" + recaptcha_response;

            //Create Client
            RestClient client = new RestClient(Url+ secret +"&"+ recaptcha_response);

            //Build A Request For The Api
            RestRequest request = new RestRequest(Method.POST);

            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            Recaptcha recaptcha = JsonConvert.DeserializeObject<Recaptcha>(response);

            return recaptcha.success;
        }
    }
}
