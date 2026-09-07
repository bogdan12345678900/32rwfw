using Microsoft.AspNetCore.Mvc;
using MovieCatalog.Services;

namespace MovieCatalog.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovieService _movieService;

        public HomeController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        public IActionResult Index()
        {
            var movies = _movieService.GetTopMovies();
            return View(movies);
        }
    }
}