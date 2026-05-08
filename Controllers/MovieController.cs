using FilmListesi_proje1.Models;
using Microsoft.AspNetCore.Mvc;


namespace FilmListesi_proje1.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View(movies);
        }

        public IActionResult Create()
        {
            return View();
        }
        public static List<Movie> movies = new List<Movie>();

        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            movies.Add(movie);

            return RedirectToAction("Index");
        }
    }
}
