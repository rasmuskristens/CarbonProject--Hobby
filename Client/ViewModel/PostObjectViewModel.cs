using CarbonProject.Client.Repository;
using CarbonProject.Shared;

namespace CarbonProject.Client.ViewModel
{
    public class PostObjectViewModel
    {

        private static PostObjectReposity repository;
        public void init()
        {
            if (repository == null)
            {
                repository = PostObjectReposity.getInstance();
            }
        }

        public async Task<HttpResponseMessage> FetchAsync()
        {
            return await repository.PostFlight();
        }
    }
}
