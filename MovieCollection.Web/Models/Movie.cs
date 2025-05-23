using System.ComponentModel.DataAnnotations;

namespace MovieCollection.Web.Models;

public class Movie
{
    public int Id { get; set; }   
    public string Title { get; set; } = null!;
    public string Director { get; set; } = null!;
    public string Year { get; set; } = null!;
    public string? ExternalUrl { get; set; }
}
