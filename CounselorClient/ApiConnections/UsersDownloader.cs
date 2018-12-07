using CounselorClient.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounselorClient.ApiConnections
{
    class UsersDownloader
    {
        private IApiResponseObserver UsersObserver;
        private RestClient Client;
        private string BaseUrl = "https://mshf.ir/api/";
        private string SignUpUrl = "v1/userslist/" + 13;

        public UsersDownloader()
        {
            Client = new RestClient(baseUrl: BaseUrl);
        }

        public void GetUsers()
        {
            var request = new RestRequest(SignUpUrl, Method.GET);
            request.AddHeader("token", "aiteam2018");
            var asyncHandle = Client.ExecuteAsync<List<User>>(request, response =>
            {
                NotifyObserver(response.Data);
            });

        }

        public void Attach(IApiResponseObserver observer)
        {
            UsersObserver = observer;
        }

        private void NotifyObserver(List<User> result)
        {
            UsersObserver.OnResponse(result, RequestCodes.UsersDownloaded);
        }
    }
}
