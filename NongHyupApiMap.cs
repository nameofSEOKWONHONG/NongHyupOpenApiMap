using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;

namespace NongHyupApi
{
    public class ApiClient
        //<TSedner, TReceiver>
        //where TSedner : class
        //where TReceiver : class
    {
        public string OptUrl { get; set; }

        public ApiClient() { }
        public ApiClient(string optUrl) {
            this.OptUrl = optUrl;
        }

        public TReceiver Client<TSender, TReceiver>(TSender data)
        {
            if (data == null) throw new Exception("send data is null.");
            if (string.IsNullOrEmpty(OptUrl)) throw new Exception("not init OptUrl");

            using (HttpClient client = new HttpClient())
            {
                var senderJson = JsonConvert.SerializeObject(data);

                var content = new StringContent(senderJson, Encoding.UTF8, "application/json");

                var result = client.PostAsync(OptUrl, content).Result;

                if (result.IsSuccessStatusCode)
                {
                    var receiveJson = result.Content.ReadAsStringAsync().Result;

                    return JsonConvert.DeserializeObject<TReceiver>(receiveJson);
                }
            }

            return default(TReceiver);
        }

        public TReceiver Client<TReceiver>(string json)
        {
            if (string.IsNullOrEmpty(json)) throw new Exception("send json is null.");
            if (string.IsNullOrEmpty(OptUrl)) throw new Exception("not init OptUrl");

            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var result = client.PostAsync(OptUrl, content).Result;

                if (result.IsSuccessStatusCode)
                {
                    var receiveJson = result.Content.ReadAsStringAsync().Result;

                    return JsonConvert.DeserializeObject<TReceiver>(receiveJson);
                }
            }

            return default(TReceiver);
        }

        public string GenerateJson<TSender>(TSender data)
        {
            return JsonConvert.SerializeObject(data);
        }
    }
}
