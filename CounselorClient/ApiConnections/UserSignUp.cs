using CounselorClient.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CounselorClient.Forms;

namespace CounselorClient.ApiConnections
{
    class UserSignUp
    {
        private IApiResponseObserver SignUpObserver;
        private RestClient Client;
        private string BaseUrl = "https://mshf.ir/api/";
        private string SignUpUrl = "v1/userssignup";

        public UserSignUp()
        {
            Client = new RestClient(baseUrl: BaseUrl);
            Client.AddDefaultHeader("token", "aiteam2018");
        }

        public void SignUp(User user)
        {
            var request = new RestRequest(SignUpUrl, Method.POST);
            request.AddHeader("token", "aiteam2018");
            request.AddParameter("application/json; charset=utf-8", JsonConvert.SerializeObject(user), ParameterType.RequestBody);
            var asyncHandle = Client.ExecuteAsync<int>(request, response =>
            {
                NotifyObserver(response.Data);
            });

        }

        public void Attach(IApiResponseObserver observer)
        {
            SignUpObserver = observer;
        }

        private void NotifyObserver(int result)
        {
            SignUpObserver.OnResponse<int>(result);
        }
    }
}
