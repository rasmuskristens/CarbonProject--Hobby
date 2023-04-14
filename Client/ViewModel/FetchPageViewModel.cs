using CarbonProject.Client.Repository;
using CarbonProject.Shared;

namespace CarbonProject.Client.ViewModel
{
    public class FetchPageViewModel
    {
        private static FetchPageRepository repo;

        

        public void init()
        {
            if(repo == null)
            {
                repo = FetchPageRepository.getInstance();
            }
        }

        public async Task<List<Root>> FetchAsync()
            {
            return await repo.fetchDataAsync();
            }

}
}
