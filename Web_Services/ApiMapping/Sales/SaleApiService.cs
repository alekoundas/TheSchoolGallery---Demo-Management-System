using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_DomainClasses.Entities.Sales;

namespace Web_Services.ApiMapping.Sales
{
    public class SaleApiService
    {
        //Constant Url To WebApi
        private string Url = ConfigurationManager.AppSettings["WebApiHost"] + "/api/Sale";


         //                GET All Sales                    \\
        //         Method:GET  -->  /api/Sale               \\
        public List<Sale> GetSales()
        {
            //Create Client
            RestClient client = new RestClient(Url);

            //Build A Request For The Api    GET
            RestRequest request = new RestRequest(Method.GET);

            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            List<Sale> SaleList = new List<Sale>();
            SaleList = JsonConvert.DeserializeObject<List<Sale>>(response);

            return SaleList;
        }



        //                GET All Sale By ID                \\
        //          Method:GET  -->  /api/Sale/id            \\
        public Sale GetSale(int? Id)
        {
            //Create Client
            RestClient client = new RestClient(Url + "/" + Id);

            //Build A Request For The Api    GET
            RestRequest request = new RestRequest(Method.GET);

            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            Sale Sale = JsonConvert.DeserializeObject<Sale>(response);

            return Sale;
        }





        //               CREATE Sale                 \\
        //       Method:POST  -->  /api/Sale/id       \\

        public void CreateSale(Sale Sale)
        {
            //Create Client
            RestClient client = new RestClient(Url);

            //Build A Request For The Api    PUT
            RestRequest request = new RestRequest(Method.POST);
            request.AddJsonBody(Sale);
            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            Sale Sales = JsonConvert.DeserializeObject<Sale>(response);
        }
    }
}
