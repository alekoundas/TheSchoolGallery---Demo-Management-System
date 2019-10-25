using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_DomainClasses.Entities.School;

namespace Web_Services.ApiMapping
{
    public class SchoolApiService
    {
        //Constant Url To WebApi
        const string Url = "https://localhost:44300/api/School";


        //                GET All Schools                    \\
        //         Method:GET  -->  /api/School               \\
        public List<School> GetSchools()
        {
            //Create Client
            RestClient client = new RestClient(Url);

            //Build A Request For The Api    GET
            RestRequest request = new RestRequest(Method.GET);

            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            List<School> SchoolList = new List<School>();
            SchoolList = JsonConvert.DeserializeObject<List<School>>(response);
            return SchoolList;
        }



        //                GET All School By ID                \\
        //          Method:GET  -->  /api/School/id            \\
        public School GetSchool(int? Id)
        {
            //Create Client
            RestClient client = new RestClient(Url + "/" + Id);

            //Build A Request For The Api    GET
            RestRequest request = new RestRequest(Method.GET);

            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            School School = JsonConvert.DeserializeObject<School>(response);

            return School;
        }




        //                EDIT School By ID                   \\
        //           Method:PUT  -->  /api/School/id           \\
        public void EditSchool(School School)
        {
            //Create Client
            RestClient client = new RestClient(Url + "/" + School.SchoolId);

            //Build A Request For The Api    PUT
            RestRequest request = new RestRequest(Method.PUT);
            request.AddJsonBody(School);
            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            School Schools = JsonConvert.DeserializeObject<School>(response);
        }



        //               CREATE School By ID           \\
        //       Method:POST  -->  /api/School/id       \\

        public void CreateSchool(School School)
        {
            //Create Client
            RestClient client = new RestClient(Url + "/" + School.SchoolId);

            //Build A Request For The Api    PUT
            RestRequest request = new RestRequest(Method.POST);
            request.AddJsonBody(School);
            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            School Schools = JsonConvert.DeserializeObject<School>(response);
        }

        //               DELETE School By ID                 \\
        //        Method:DELETE  -->  /api/School/id          \\

        public void DeleteSchool(int id)
        {
            //Create Client
            RestClient client = new RestClient(Url + "/" + id);

            //Build A Request For The Api    PUT
            RestRequest request = new RestRequest(Method.DELETE);

            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            School Schools = JsonConvert.DeserializeObject<School>(response);
        }
    }
}
