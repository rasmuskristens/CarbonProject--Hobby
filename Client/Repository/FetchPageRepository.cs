using CarbonProject.Shared;
using Newtonsoft.Json;

namespace CarbonProject.Client.Repository
{
    public class FetchPageRepository
    {
        private static FetchPageRepository instance;
        List<Root> result;
        HttpClient client;
        public FetchPageRepository() 
        {
            result = new List<Root>();

            client = new HttpClient();
        }

        public static FetchPageRepository getInstance()
        {
            if (instance == null)
            {
                instance = new FetchPageRepository();
            }
            return instance;
        }

        public async Task<List<Root>> fetchDataAsync()
        {
            
            var request = new HttpRequestMessage(HttpMethod.Get, Environment.HTTPMethod_Get);
            request.Headers.Add("Authorization", Environment.AuthKey);

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            string responseContent = await response.Content.ReadAsStringAsync();

            if (!string.IsNullOrEmpty(responseContent))
            {
                result = JsonConvert.DeserializeObject<List<Root>>(responseContent);
            }
            

            return result;
        }
    }
}
