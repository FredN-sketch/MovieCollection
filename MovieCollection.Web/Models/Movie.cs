using Microsoft.AspNetCore.Connections;
using System.ComponentModel.DataAnnotations;

namespace MovieCollection.Web.Models;

public class Movie
{
    public int Id { get; set; }
    [Required]
    public string Title { get; set; } = null!;
    [Required]
    public string Director { get; set; } = null!;
    [Required(ErrorMessage = "Enter a valid year")]
    public int Year { get; set; } 

    public string? ExternalUrl { get; set; }
}
