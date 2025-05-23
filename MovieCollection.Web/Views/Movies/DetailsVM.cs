namespace MovieCollection.Web.Views.Movies
{
    public class DetailsVM
    {
        public required int Id { get; set; }
        public required string Title { get; set; }    
        public required string Director { get; set; } 
        public required int? Year { get; set; }
        public string? ExternalUrl { get; set; }
    }
}
