using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_DomainClasses.Entities.School;

namespace Web_Services.ApiMapping
{
    public class ClassroomApiService
    {
        //Constant Url To WebApi
        const string Url = "https://localhost:44300/api/Classroom";


        //                GET All Classrooms                    \\
        //         Method:GET  -->  /api/Classroom               \\
        public List<Classroom> GetClassrooms()
        {
            //Create Client
            RestClient client = new RestClient(Url);

            //Build A Request For The Api    GET
            RestRequest request = new RestRequest(Method.GET);

            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            List<Classroom> ClassroomList = new List<Classroom>();
            ClassroomList = JsonConvert.DeserializeObject<List<Classroom>>(response);

            return ClassroomList;
        }



        //                GET All Classroom By ID                \\
        //          Method:GET  -->  /api/Classroom/id            \\
        public Classroom GetClassroom(int? Id)
        {
            //Create Client
            RestClient client = new RestClient(Url + "/" + Id);

            //Build A Request For The Api    GET
            RestRequest request = new RestRequest(Method.GET);

            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            Classroom Classroom = JsonConvert.DeserializeObject<Classroom>(response);

            return Classroom;
        }




        //                EDIT Classroom By ID                   \\
        //           Method:PUT  -->  /api/Classroom/id           \\
        public void EditClassroom(Classroom Classroom)
        {
            //Create Client
            RestClient client = new RestClient(Url + "/" + Classroom.ClassroomId);

            //Build A Request For The Api    PUT
            RestRequest request = new RestRequest(Method.PUT);
            request.AddJsonBody(Classroom);
            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            Classroom Classrooms = JsonConvert.DeserializeObject<Classroom>(response);
        }



        //               CREATE Classroom By ID           \\
        //       Method:POST  -->  /api/Classroom/id       \\

        public void CreateClassroom(Classroom Classroom)
        {
            //Create Client
            RestClient client = new RestClient(Url + "/" + Classroom.ClassroomId);

            //Build A Request For The Api    PUT
            RestRequest request = new RestRequest(Method.POST);
            request.AddJsonBody(Classroom);
            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            Classroom Classrooms = JsonConvert.DeserializeObject<Classroom>(response);
        }

        //               DELETE Classroom By ID                 \\
        //        Method:DELETE  -->  /api/Classroom/id          \\

        public void DeleteClassroom(int? id)
        {
            //Create Client
            RestClient client = new RestClient(Url + "/" + id);

            //Build A Request For The Api    PUT
            RestRequest request = new RestRequest(Method.DELETE);

            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            Classroom Classrooms = JsonConvert.DeserializeObject<Classroom>(response);
        }
    }
}
