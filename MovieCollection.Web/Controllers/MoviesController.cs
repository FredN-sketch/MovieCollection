using Microsoft.AspNetCore.Mvc;
using MovieCollection.Web.Models;
using MovieCollection.Web.Services;

namespace MovieCollection.Web.Controllers
{
    public class MoviesController(MovieService movieService) : Controller
    {
      //  static MovieService movieService = new MovieService();
        [HttpGet("")]
        public IActionResult Index()
        {
            var model = movieService.GetAll();
            return View(model);
        }
        [HttpGet("Create")]
        public IActionResult Create() 
        { 
            return View();
        }
        [HttpPost("Create")]
        public IActionResult Create(Movie movie) 
        {
            if (!ModelState.IsValid) 
            {
                return View();
            }
            movieService.Add(movie);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet("details/{id}")]
        public IActionResult Details(int id) 
        {
            var model = movieService.GetById(id);
            return View(model);        
        }
    }
}
