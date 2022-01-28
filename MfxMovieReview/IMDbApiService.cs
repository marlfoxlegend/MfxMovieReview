namespace MfxMovieReview;

public class IMDbApiService
{
    private static HttpClient s_httpClient;

    public IMDbApiService(HttpClient client)
    {
        s_httpClient = client;
    }

    public async Task<Models.MostPopularData?> GetMostPopularData(string apiKey)
    {
        Uri relativeUri = new($"MostPopularMovies/{apiKey}", UriKind.Relative);
        return await s_httpClient.GetFromJsonAsync<Models.MostPopularData>(relativeUri);
    }
}
