using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounselorClient.ApiConnections
{
    class UserRoleType
    {
        private IApiResponseObserver RoleTypeObserver;
        private RestClient Client;
        private string BaseUrl = "https://mshf.ir/api/";
        private string RoleTypeUrl = "v1/usersid/";

        public UserRoleType()
        {
            Client = new RestClient(baseUrl: BaseUrl);
            Client.AddDefaultHeader("token", "aiteam2018");
        }

        public void GetUserRoleId(int userId)
        {
            var request = new RestRequest(RoleTypeUrl + userId, Method.GET);
            request.AddHeader("token", "aiteam2018");
            var asyncHandle = Client.ExecuteAsync<int>(request, response =>
            {
                NotifyObserver(response.Data);
            });

        }

        public void Attach(IApiResponseObserver observer)
        {
            RoleTypeObserver = observer;
        }

        private void NotifyObserver(int result)
        {
            RoleTypeObserver.OnResponse(result, RequestCodes.RoleTypeReceived);
        }
    }
}
