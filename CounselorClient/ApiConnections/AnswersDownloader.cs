using RestSharp;
using System.Collections.Generic;

namespace CounselorClient.ApiConnections
{
    class AnswersDownloader
    {
        private IApiResponseObserver AnswersObserver;
        private RestClient Client;
        private string BaseUrl = "https://mshf.ir/api/";
        private string AnswersUrl = "v1/answersbot/";

        public AnswersDownloader()
        {
            Client = new RestClient(baseUrl: BaseUrl);
        }

        public void GetAnswers(int questionId)
        {
            var request = new RestRequest(AnswersUrl + questionId, Method.GET);
            request.AddHeader("token", "aiteam2018");
            var asyncHandle = Client.ExecuteAsync<List<string>>(request, response =>
            {
                NotifyObserver(response.Data);
            });

        }

        public void Attach(IApiResponseObserver observer)
        {
            AnswersObserver = observer;
        }

        private void NotifyObserver(List<string> result)
        {
            AnswersObserver.OnResponse(result, RequestCodes.ChatsReceived);
        }
    }
}
