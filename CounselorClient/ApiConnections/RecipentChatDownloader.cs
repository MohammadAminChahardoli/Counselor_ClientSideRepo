using CounselorClient.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounselorClient.ApiConnections
{
    class RecipentChatDownloader
    {
        private IApiResponseObserver ChatsObserver;
        private RestClient Client;
        private string BaseUrl = "https://mshf.ir/api/";
        private string ChatUrl = "v1/chathistoryuser/";

        public RecipentChatDownloader()
        {
            Client = new RestClient(baseUrl: BaseUrl);
        }

        public void GetChats(int userId)
        {
            var request = new RestRequest(ChatUrl + userId, Method.GET);
            request.AddHeader("token", "aiteam2018");
            var asyncHandle = Client.ExecuteAsync<List<Chat>>(request, response =>
            {
                NotifyObserver(response.Data);
            });

        }

        public void Attach(IApiResponseObserver observer)
        {
            ChatsObserver = observer;
        }

        private void NotifyObserver(List<Chat> result)
        {
            ChatsObserver.OnResponse(result, RequestCodes.ChatsReceived);
        }
    }
}
