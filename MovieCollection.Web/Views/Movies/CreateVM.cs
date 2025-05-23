using MovieCollection.Web.Models;
using System.ComponentModel.DataAnnotations;

namespace MovieCollection.Web.Views.Movies
{
    public class CreateVM
    {
        [Required(ErrorMessage = "Enter a title")]
        public string Title { get; set; } = null!;
        [Required(ErrorMessage = "Enter a director")]
        public string Director { get; set; } = null!;
        [Required(ErrorMessage = "Enter a valid year")]
        [YearRange(1888, ErrorMessage = "Enter a valid year between 1888 and now")]
        public int Year { get; set; }
        [Display(Name = "External link")]
        public string? ExternalUrl { get; set; }
    }
}
