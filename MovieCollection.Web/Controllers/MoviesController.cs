using Microsoft.AspNetCore.Mvc;
using MovieCollection.Web.Services;

namespace MovieCollection.Web.Controllers
{
    public class MoviesController : Controller
    {
        static MovieService movieService = new MovieService();
        [HttpGet("")]
        public IActionResult Index()
        {
            var model = movieService.GetAll();
            return View(model);
        }
        [HttpGet("details/{id}")]
        public IActionResult Details(int id) 
        {
            var model = movieService.GetById(id);
            return View(model);        
        }
    }
}
