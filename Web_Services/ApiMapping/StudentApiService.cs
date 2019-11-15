using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_DomainClasses.Entities.School;

namespace Web_Services.ApiMapping
{
    public class StudentApiService
    {
        //Constant Url To WebApi
        private string Url = ConfigurationManager.AppSettings["WebApiHost"] + "/api/Student";


        //                GET All Students                    \\
        //         Method:GET  -->  /api/Student               \\
        public List<Student> GetStudents()
        {
            //Create Client
            RestClient client = new RestClient(Url);

            //Build A Request For The Api    GET
            RestRequest request = new RestRequest(Method.GET);

            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            List<Student> StudentList = new List<Student>();
            StudentList = JsonConvert.DeserializeObject<List<Student>>(response);

            return StudentList;
        }



        //                GET Student By ID                   \\
        //          Method:GET  -->  /api/Student/id           \\
        public Student GetStudent(int? Id)
        {
            //Create Client
            RestClient client = new RestClient(Url + "/" + Id);

            //Build A Request For The Api    GET
            RestRequest request = new RestRequest(Method.GET);

            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            Student Student = JsonConvert.DeserializeObject<Student>(response);

            return Student;
        }




        //                EDIT Student By ID                   \\
        //           Method:PUT  -->  /api/Student/id           \\
        public void EditStudent(Student Student)
        {
            //Create Client
            RestClient client = new RestClient(Url + "/" + Student.StudentId);

            //Build A Request For The Api    PUT
            RestRequest request = new RestRequest(Method.PUT);
            request.AddJsonBody(Student);
            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            Student Students = JsonConvert.DeserializeObject<Student>(response);
        }



        //               CREATE Student By ID           \\
        //       Method:POST  -->  /api/Student/id       \\

        public void CreateStudent(Student Student)
        {
            //Create Client
            RestClient client = new RestClient(Url + "/" + Student.StudentId);

            //Build A Request For The Api    POST
            RestRequest request = new RestRequest(Method.POST);
            request.AddJsonBody(Student);
            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            Student Students = JsonConvert.DeserializeObject<Student>(response);
        }

        //               DELETE Student By ID                 \\
        //        Method:DELETE  -->  /api/Student/id          \\

        public void DeleteStudent(int id)
        {
            //Create Client
            RestClient client = new RestClient(Url + "/" + id);

            //Build A Request For The Api    DELETE
            RestRequest request = new RestRequest(Method.DELETE);

            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            Student Students = JsonConvert.DeserializeObject<Student>(response);
        }
    }
}
