using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_DomainClasses.Entities.SignalR;

namespace Web_Services.ApiMapping
{
    public class MessageApiService
    {//Constant Url To WebApi
        const string Url = "https://localhost:44300/api/MessageHistory";


         //                GET All MessageHistorys                   \\
        //         Method:GET  -->  /api/MessageHistory               \\
        public List<MessageHistory> GetMessageHistorys()
        {
            //Create Client
            RestClient client = new RestClient(Url);

            //Build A Request For The Api    GET
            RestRequest request = new RestRequest(Method.GET);

            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            List<MessageHistory> MessageHistoryList = new List<MessageHistory>();
            MessageHistoryList = JsonConvert.DeserializeObject<List<MessageHistory>>(response);

            return MessageHistoryList;
        }



        //               CREATE MessageHistory                 \\
        //       Method:POST  -->  /api/MessageHistory/id       \\

        public void CreateMessageHistory(MessageHistory MessageHistory)
        {
            //Create Client
            RestClient client = new RestClient(Url + "/" + MessageHistory.MessageHistoryId);

            //Build A Request For The Api    PUT
            RestRequest request = new RestRequest(Method.POST);
            request.AddJsonBody(MessageHistory);
            //Execute Request
            var response = client.Execute(request).Content;

            //Desirialise Response(JSON) To Model
            MessageHistory MessageHistorys = JsonConvert.DeserializeObject<MessageHistory>(response);
        }    
    }
}
