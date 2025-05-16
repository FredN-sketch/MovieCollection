using Microsoft.AspNetCore.Connections;
using System.ComponentModel.DataAnnotations;

namespace MovieCollection.Web.Models;

public class Movie
{
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Director { get; set; }
    [Required]
    public int Year { get; set; }
    [Required]
    public string ExternalUrl { get; set; }
}
