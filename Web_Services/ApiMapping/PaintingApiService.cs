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
   public  class PaintingApiService
    {
        //Constant Url To WebApi
        const string Url = "https://localhost:44300/api/Painting";


        //                GET All Paintings                    \\
        //         Method:GET  -->  /api/Painting               \\
        public List<Painting> GetPaintings()
        {
            //Create Client
            RestClient client = new RestClient(Url);

            //Build A Request For The Api    GET
            RestRequest request = new RestRequest(Method.GET);

            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            List<Painting> PaintingList = new List<Painting>();
            PaintingList = JsonConvert.DeserializeObject<List<Painting>>(response);

            return PaintingList;
        }



        //                GET Painting By ID                   \\
        //          Method:GET  -->  /api/Painting/id           \\
        public Painting GetPainting(int? Id)
        {
            //Create Client
            RestClient client = new RestClient(Url + "/" + Id);

            //Build A Request For The Api    GET
            RestRequest request = new RestRequest(Method.GET);

            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            Painting painting = JsonConvert.DeserializeObject<Painting>(response);

            return painting;
        }




        //                EDIT Painting By ID                   \\
        //           Method:PUT  -->  /api/Painting/id           \\
        public void EditPainting(Painting Painting)
        {
            //Create Client
            RestClient client = new RestClient(Url + "/" + Painting.PaintingId);

            //Build A Request For The Api    PUT
            RestRequest request = new RestRequest(Method.PUT);
            request.AddJsonBody(Painting);
            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            Painting Paintings = JsonConvert.DeserializeObject<Painting>(response);
        }



        //               CREATE Painting By ID           \\
        //       Method:POST  -->  /api/Painting/id       \\

        public void CreatePainting(Painting Painting)
        {
            //Create Client
            RestClient client = new RestClient(Url + "/" + Painting.PaintingId);

            //Build A Request For The Api    PUT
            RestRequest request = new RestRequest(Method.POST);
            request.AddJsonBody(Painting);
            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            Painting Paintings = JsonConvert.DeserializeObject<Painting>(response);
        }

        //               DELETE Painting By ID                 \\
        //        Method:DELETE  -->  /api/Painting/id          \\

        public void DeletePainting(int id)
        {
            //Create Client
            RestClient client = new RestClient(Url + "/" + id);

            //Build A Request For The Api    PUT
            RestRequest request = new RestRequest(Method.DELETE);

            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            Painting Paintings = JsonConvert.DeserializeObject<Painting>(response);
        }
    }
}
