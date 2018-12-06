using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounselorClient
{
    class JsonHandler
    {

        public static string Serialize<T>(T @object)
        {
            return JsonConvert.SerializeObject(@object);
        }

        public static T Deserialize<T>(string jsonString)
        {
            var result = JsonConvert.DeserializeObject<T>(jsonString);
            return (T)Convert.ChangeType(result, typeof(T));
        }
    }
}
