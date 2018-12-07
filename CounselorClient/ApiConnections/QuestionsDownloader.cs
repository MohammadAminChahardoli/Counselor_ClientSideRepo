using CounselorClient.Models;
using RestSharp;
using System.Collections.Generic;

namespace CounselorClient.ApiConnections
{
    class QuestionsDownloader
    {
        private IApiResponseObserver QuestionsObserver;
        private RestClient Client;
        private string BaseUrl = "https://mshf.ir/api/";
        private string SignUpUrl = "v1/questions";

        public QuestionsDownloader()
        {
            Client = new RestClient(baseUrl: BaseUrl);
        }

        public void GetQuestions()
        {
            var request = new RestRequest(SignUpUrl, Method.GET);
            request.AddHeader("token", "aiteam2018");
            var asyncHandle = Client.ExecuteAsync<List<Question>>(request, response =>
            {
                NotifyObserver(response.Data);
            });

        }

        public void Attach(IApiResponseObserver observer)
        {
            QuestionsObserver = observer;
        }

        private void NotifyObserver(List<Question> result)
        {
            QuestionsObserver.OnResponse(result, RequestCodes.QuestionDownloaded);
        }
    }
}
