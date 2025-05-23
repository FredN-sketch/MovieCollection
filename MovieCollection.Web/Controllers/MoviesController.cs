using Microsoft.AspNetCore.Mvc;
using MovieCollection.Web.Models;
using MovieCollection.Web.Services;
using MovieCollection.Web.Views.Movies;


namespace MovieCollection.Web.Controllers
{
    public class MoviesController(MovieService movieService) : Controller
    {
      //  static MovieService movieService = new MovieService();
        [HttpGet("")]
        public IActionResult Index()
        {
            var model = movieService.GetAll();
            var viewModel = new IndexVM()
            {
                MovieVMs = model
               .Select(e => new IndexVM.MovieVM()
               {
                   Id = e.Id,
                   Title = e.Title,                  
               })
               .ToArray()
            };
            return View(viewModel);
        }
        [HttpGet("Create")]
        public IActionResult Create() 
        { 
            return View();
        }
        [HttpPost("Create")]
        public IActionResult Create(CreateVM viewModel) 
        {
            if (!ModelState.IsValid) 
            {
                return View();
            }
            Movie movie = new() 
            { 
                Title = viewModel.Title,
                Director = viewModel.Director,
                Year = viewModel.Year,
                ExternalUrl = viewModel.ExternalUrl,
            };

            movieService.Add(movie);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet("details/{id}")]
        public IActionResult Details(int id) 
        {
            var model = movieService.GetById(id);
            DetailsVM viewModel = new()
            {
                Id = model.Id,
                Title = model.Title,
                Director = model.Director,
                Year = model.Year,
                ExternalUrl = model.ExternalUrl,
            };

            return View(viewModel);        
        }
    }
}
