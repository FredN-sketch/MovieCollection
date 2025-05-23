namespace MovieCollection.Web.Views.Movies
{
    public class IndexVM
    {
        public MovieVM[] MovieVMs { get; set; } = null!;
        public class MovieVM
        {
            public required int Id { get; set; }
            public required string Title { get; set; }
        }
    }
}
