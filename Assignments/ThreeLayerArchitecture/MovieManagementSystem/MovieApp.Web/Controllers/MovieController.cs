using Microsoft.AspNetCore.Mvc;
using MovieApp.Business.DTOs;
using MovieApp.Business.Services;

namespace MovieApp.Web.Controllers
{
    [Route("[Controller]")]
    public class MovieController : Controller
    {
        private readonly IMovieServices movie_repo;

        public MovieController(IMovieServices movie_repo)
        {
            this.movie_repo = movie_repo;
        }

        [HttpGet]
        [Route("")]
        [Route("Index")]
        [Route("GetAllMovies")]
        public IActionResult Index()
        {
            var movies = movie_repo.GetAllMovies();
            return View(movies);
        }

        [HttpGet]
        [Route("GetMovie/{title}")]
        public IActionResult Details(string title)
        {
            var movie = movie_repo.GetMovieById(title);
            return View(movie);
        }

        [HttpGet]
        [Route("Create")]
        public IActionResult Create()
        {
            return View(new MovieDTO());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Create")]
        public IActionResult Create(MovieDTO movieDTO)
        {
            if (!ModelState.IsValid)
            {
                return View(movieDTO);
            }

            movie_repo.AddMovie(movieDTO);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("Edit/{title}")]
        public IActionResult Edit(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                return BadRequest();
            }

            var movie = movie_repo.GetMovieById(title);
            if (movie is null)
            {
                return NotFound();
            }

            return View(movie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Edit")]
        public IActionResult Edit(MovieDTO movieDTO)
        {
            if (!ModelState.IsValid)
            {
                return View(movieDTO);
            }

            movie_repo.UpdateMovie(movieDTO);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("Delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            movie_repo.DeleteMovie(id);
            return RedirectToAction("Index");
        }
    }
}
