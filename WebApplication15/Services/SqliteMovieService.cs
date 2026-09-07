using MovieCatalog.Data;
using MovieCatalog.Models;

namespace MovieCatalog.Services
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