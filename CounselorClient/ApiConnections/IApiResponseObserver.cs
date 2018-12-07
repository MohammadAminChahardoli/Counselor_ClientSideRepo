using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounselorClient.ApiConnections
{
    interface IApiResponseObserver
    {
        void OnResponse(object response, RequestCodes requestCode);
    }
}
