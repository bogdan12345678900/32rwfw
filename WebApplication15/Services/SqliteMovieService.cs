using WebApplication15.Data;
using WebApplication15.Models;

namespace WebApplication15.Services
{
    public class SqliteMovieService : IMovieService
    {
        private readonly ApplicationDbContext _context;

        public SqliteMovieService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Movie> GetTopMovies()
        {
            return _context.Movies.ToList();
        }
    }
}