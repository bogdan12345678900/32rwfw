using MovieCatalog.Models;

namespace MovieCatalog.Services
{
    public interface IMovieService
    {
        IEnumerable<Movie> GetTopMovies();
    }
}