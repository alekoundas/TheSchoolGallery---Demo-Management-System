using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_DomainClasses.Entities.Avatar;
using Web_DomainClasses.Entities.School;

namespace Web_Services.ApiMapping
{
    public class TeacherApiService
    {
        //Constant Url To WebApi
        private string Url = ConfigurationManager.AppSettings["WebApiHost"] + "/api/Teacher";


        //                GET All Teachers                    \\
        //         Method:GET  -->  /api/Teacher               \\
        public List<Teacher> GetTeachers()
        {
            //Create Client
            RestClient client = new RestClient(Url);

            //Build A Request For The Api    GET
            RestRequest request = new RestRequest(Method.GET);

            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            List<Teacher> TeacherList = new List<Teacher>();
            TeacherList = JsonConvert.DeserializeObject<List<Teacher>>(response);

            return TeacherList;
        }



        //                GET All Teacher By ID                \\
        //          Method:GET  -->  /api/Teacher/id            \\
        public Teacher GetTeacher(int? Id)
        {
            //Create Client
            RestClient client = new RestClient(Url+"/"+Id);

            //Build A Request For The Api    GET
            RestRequest request = new RestRequest(Method.GET);

            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            Teacher teacher = JsonConvert.DeserializeObject<Teacher>(response);

            return teacher;
        }




        //                EDIT Teacher By ID                   \\
        //           Method:PUT  -->  /api/Teacher/id           \\
        public void EditTeacher(Teacher teacher)
        {
            //Create Client
            RestClient client = new RestClient(Url+"/"+ teacher.TeacherId);

            //Build A Request For The Api    PUT
            RestRequest request = new RestRequest(Method.PUT);
            request.AddJsonBody(teacher);
            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            Teacher teachers = JsonConvert.DeserializeObject<Teacher>(response);
        }



        //               CREATE Teacher By ID           \\
        //       Method:POST  -->  /api/Teacher/id       \\

        public void CreateTeacher(Teacher teacher)
        {
            //Create Client
            RestClient client = new RestClient(Url+"/"+ teacher.TeacherId);

            //Build A Request For The Api    PUT
            RestRequest request = new RestRequest(Method.POST);
            request.AddJsonBody(teacher);
            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            Teacher teachers = JsonConvert.DeserializeObject<Teacher>(response);
        }

        //               DELETE Teacher By ID                 \\
        //        Method:DELETE  -->  /api/Teacher/id          \\

        public void DeleteTeacher(int id)
        {
            //Create Client
            RestClient client = new RestClient(Url+"/"+ id);

            //Build A Request For The Api    PUT
            RestRequest request = new RestRequest(Method.DELETE);

            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            Teacher teachers = JsonConvert.DeserializeObject<Teacher>(response);
        }
    }
}
