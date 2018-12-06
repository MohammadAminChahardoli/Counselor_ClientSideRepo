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
    class UserSingIn
    {
        private IApiResponseObserver SignInObserver;
        private RestClient Client;
        private string BaseUrl = "https://mshf.ir/api/";
        private string SignUpUrl = "v1/userslogin";

        public UserSingIn()
        {
            Client = new RestClient(baseUrl: BaseUrl);
            Client.AddDefaultHeader("token", "aiteam2018");
        }

        public void SignIn(SignInModel info)
        {
            var request = new RestRequest(SignUpUrl, Method.POST);
            request.AddParameter("application/json; charset=utf-8", JsonConvert.SerializeObject(info), ParameterType.RequestBody);
            var asyncHandle = Client.ExecuteAsync<int>(request, response =>
            {
                NotifyObserver(response.Data);
            });

        }

        public void Attach(IApiResponseObserver observer)
        {
            SignInObserver = observer;
        }

        private void NotifyObserver(int result)
        {
            SignInObserver.OnResponse<int>(result);
        }
    }
}
