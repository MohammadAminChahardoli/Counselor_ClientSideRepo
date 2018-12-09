using CounselorClient.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounselorClient.ApiConnections
{
    class RobotMessageUploader
    {
        private IApiResponseObserver ChatObserver;
        private RestClient Client;
        private string BaseUrl = "https://mshf.ir/api/";
        private string CahtUrl = "v1/newchat";

        public RobotMessageUploader()
        {
            Client = new RestClient(baseUrl: BaseUrl);
            Client.AddDefaultHeader("token", "aiteam2018");
        }

        public void InsertNewMessage(NewChatModel chatModel)
        {
            var request = new RestRequest(CahtUrl, Method.POST);
            request.AddHeader("token", "aiteam2018");
            request.AddParameter("application/json; charset=utf-8", JsonConvert.SerializeObject(chatModel), ParameterType.RequestBody);
            var asyncHandle = Client.ExecuteAsync<bool>(request, response =>
            {
                NotifyObserver(response.Data);
            });

        }

        public void Attach(IApiResponseObserver observer)
        {
            ChatObserver = observer;
        }

        private void NotifyObserver(bool result)
        {
            ChatObserver.OnResponse(result, RequestCodes.NewMessageSentFromRobot);
        }
    }
}
