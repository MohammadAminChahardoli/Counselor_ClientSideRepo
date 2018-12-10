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
    class ProperAnswerValidator
    {
        private IApiResponseObserver ProperAnswerObserver;
        private RestClient Client;
        private string BaseUrl = "https://mshf.ir/api/";
        private string ProperAnswerUrl = "v1/answerspt";

        public ProperAnswerValidator()
        {
            Client = new RestClient(baseUrl: BaseUrl);
            Client.AddDefaultHeader("token", "aiteam2018");
        }
        public void ValidateProperAnswer(ProperAnswerModel model)
        {
            var request = new RestRequest(ProperAnswerUrl, Method.POST);
            request.AddHeader("token", "aiteam2018");
            request.AddParameter("application/json; charset=utf-8", JsonConvert.SerializeObject(model), ParameterType.RequestBody);
            Client.ExecuteAsync<List<ExtractedProperAnswer>>(request, response =>
            {
                NotifyObserver(response.Data);
            });
        }

        public void Attach(IApiResponseObserver observer)
        {
            ProperAnswerObserver = observer;
        }

        private void NotifyObserver(List<ExtractedProperAnswer> result)
        {
            ProperAnswerObserver.OnResponse(result, RequestCodes.ProperAnswerValidator);
        }


    }
}
