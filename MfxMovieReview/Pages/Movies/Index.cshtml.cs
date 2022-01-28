using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MfxMovieReview.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _config;
        private readonly IMDbApiService _apiService;
        public Models.MostPopularData PopularData { get; set; }

        public IndexModel(IConfiguration config, IMDbApiService apiService)
        {
            _config = config;
            _apiService = apiService;
            PopularData = new Models.MostPopularData();
        }

        public async Task OnGetAsync()
        {
            var data = await _apiService.GetMostPopularData(_config["Movies:ServiceApiKey"]);
            if (data == null)
            {
                throw new InvalidOperationException($"{nameof(PopularData)} cannot be null.");
            }
            PopularData = data;
            if (!string.IsNullOrEmpty(PopularData?.ErrorMessage))
            {
                Console.WriteLine(
                    $"Error getting {nameof(Models.MostPopularData)}:\n{PopularData?.ErrorMessage}");
            }
        }
    }
}
