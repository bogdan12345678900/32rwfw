namespace MovieSearchApp.Services
{
    public class OmdbService : IOmdbService
    {
        public async Task<object?> GetMovieByTitleAsync(string title)
        {
            return await Task.FromResult<object?>(null);
        }
    }
}