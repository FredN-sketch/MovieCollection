using MovieCollection.Web.Models;

namespace MovieCollection.Web.Services
{
    public class MovieService
    {
        List<Movie> movies = [
            new Movie() {
                Id = 162,
                Title = "The Lost Boys",
                Director = "Joel Schumacher",
                Year = 1987,
                ExternalUrl = "https://www.imdb.com/title/tt0093437/?ref_=nm_flmg_job_1_cdt_t_32"
            },
            new Movie() {
                Id = 34,
                Title = "Blade Runner",
                Director = "Ridley Scott",
                Year = 1982,
                ExternalUrl = "https://www.imdb.com/title/tt0083658/?ref_=nm_knf_t_2"
            },
            new Movie() {
                Id = 95,
                Title = "Snatch",
                Director = "Guy Ritchie",
                Year = 2000,
                ExternalUrl = "https://www.imdb.com/title/tt0208092/?ref_=nm_knf_t_3"
            },
            new Movie() {
                Id = 287,
                Title = "An American Werewolf in London",
                Director = "John Landis",
                Year = 1981,
                ExternalUrl = "https://www.imdb.com/title/tt0082010/?ref_=nm_flmg_job_2_cdt_t_44"
            }
            ];
        public Movie[] GetAll() => movies
            .OrderBy(e => e.Title)
            .ToArray();

        public Movie GetById(int id) => movies
            .Single(e => e.Id == id);

        public void Add(Movie movie)
        {
            movie.Id = movies.Count < 0 ? 1 : movies.Max(e => e.Id) + 1;
            movies.Add(movie);
        }

    }
}
