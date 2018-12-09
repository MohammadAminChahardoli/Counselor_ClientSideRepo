using CounselorClient.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounselorClient.ApiConnections
{
    class MessageDownloader
    {
        private IApiResponseObserver MessagesObserver;
        private RestClient Client;
        private string BaseUrl = "https://mshf.ir/api/";
        private string MessageUrl = "v1/chathistory/";

        public MessageDownloader()
        {
            Client = new RestClient(baseUrl: BaseUrl);
        }

        public void GetMessages(int chatId)
        {
            var request = new RestRequest(MessageUrl + chatId, Method.GET);
            request.AddHeader("token", "aiteam2018");
            var asyncHandle = Client.ExecuteAsync<List<Message>>(request, response =>
            {
                NotifyObserver(response.Data);
            });

        }

        public void Attach(IApiResponseObserver observer)
        {
            MessagesObserver = observer;
        }

        private void NotifyObserver(List<Message> result)
        {
            MessagesObserver.OnResponse(result, RequestCodes.MessagesReceived);
        }
    }
}
