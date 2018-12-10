using CounselorClient.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;

namespace CounselorClient.ApiConnections
{
    class GetPerosonalityTypeInfo
    {
        private IApiResponseObserver ProperAnswerObserver;
        private RestClient Client;
        private string BaseUrl = "https://mshf.ir/api/";
        private string PersonalitytypefindUrl = "v1/personalitytypefind";

        public GetPerosonalityTypeInfo()
        {
            Client = new RestClient(baseUrl: BaseUrl);
            Client.AddDefaultHeader("token", "aiteam2018");
        }
        public void GetPerosnality(PerosnalityTypeModel model)
        {
            var request = new RestRequest(PersonalitytypefindUrl, Method.POST);
            request.AddHeader("token", "aiteam2018");
            request.AddParameter("application/json; charset=utf-8", JsonConvert.SerializeObject(model), ParameterType.RequestBody);
            Client.ExecuteAsync<List<UserPerosonalityTypeInfo>>(request, response =>
            {
                if (response.Data.Count > 0)
                {
                    NotifyObserver(response.Data[0]);
                }
                else
                {
                    NotifyObserver(new UserPerosonalityTypeInfo());
                }
               
            });
        }


        public void Attach(IApiResponseObserver observer)
        {
            ProperAnswerObserver = observer;
        }

        private void NotifyObserver(UserPerosonalityTypeInfo result)
        {
            ProperAnswerObserver.OnResponse(result, RequestCodes.GetPersonalityInfo);
        }
    }
}
