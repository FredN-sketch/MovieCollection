using System.ComponentModel.DataAnnotations;

namespace MovieCollection.Web.Models;

public class Movie
{
    public int Id { get; set; }
    //[Required]
    [Required(ErrorMessage = "Enter a title")]
    public string Title { get; set; } = null!;
    // [Required]
    [Required(ErrorMessage = "Enter a director")]
    public string Director { get; set; } = null!;
    [Required(ErrorMessage = "Enter a year")]
    public string? Year { get; set; }
    [Display(Name="External link")]
    public string? ExternalUrl { get; set; }
}
