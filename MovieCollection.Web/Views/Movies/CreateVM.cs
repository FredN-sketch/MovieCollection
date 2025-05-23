using System.ComponentModel.DataAnnotations;

namespace MovieCollection.Web.Views.Movies
{
    public class CreateVM
    {
        [Required(ErrorMessage = "Enter a title")]
        public string Title { get; set; } = null!;
        [Required(ErrorMessage = "Enter a director")]
        public string Director { get; set; } = null!;
        [Required(ErrorMessage = "Enter a year")]
        public string Year { get; set; } = null!;
        [Display(Name = "External link")]
        public string? ExternalUrl { get; set; }
    }
}
