using CarbonProject.Shared;
using CarbonProject.Shared.PostClass;
using Newtonsoft.Json;
using System.Net;

namespace CarbonProject.Client.Repository
{
    public class PostObjectReposity
    {

        HttpClient client;
        private static PostObjectReposity instance;
        public PostObjectReposity()
        {
            client = new HttpClient();
        }

        public static PostObjectReposity getInstance()
        {
            if (instance == null)
            {
                instance = new PostObjectReposity();
            }
            return instance;
        }


        public async Task<HttpResponseMessage> PostFlight()
        {

            var request = new HttpRequestMessage(HttpMethod.Get, Environment.HTTPMethod_Get);
            request.Headers.Add("Authorization", Environment.AuthKey);

            HttpResponseMessage responseContent = SendRequestAsync(request).Result;


            return responseContent;
        }

        private async Task<HttpResponseMessage> SendRequestAsync(HttpRequestMessage request)
        {
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return  response;
        }

    }
}
