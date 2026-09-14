namespace MovieSearchApp.Services
{
    public interface IOmdbService
    {
        Task<object?> GetMovieByTitleAsync(string title);
    }
}
