using WebApplication15.Models;

namespace WebApplication15.Services
{
    public interface IMovieService
    {
        IEnumerable<Movie> GetTopMovies();
    }
}