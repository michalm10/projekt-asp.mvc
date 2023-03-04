using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjektASP.Models
{
    public class Movie : IValidatableObject
    {
        public int Id { get; set; }
        [DisplayName("Tytuł")]
        [Required]
        [StringLength(100)]
        public string? Title { get; set; }

        [DisplayName("Data")]
        [DataType(DataType.Date)]
        [OldMovie(1950)]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [DisplayName("Gatunek")]
        public string? Genre { get; set; }

        //[ForeignKey("Director")]
        [DisplayName("Reżyser")]
        
        public int? DirectorId { get; set; }
        [DisplayName("Reżyser")]
        public virtual Director? Director { get; set; }

        public IList<Rating> Ratings { get; set; }

        public List<SelectListItem> genres = new List<SelectListItem>()
        {
            new SelectListItem { Text = "Wybierz", Value = "" },
            new SelectListItem { Text = "Akcji", Value = "action" },
            new SelectListItem { Text = "Thriller", Value = "thriller" },
            new SelectListItem { Text = "Komedia", Value = "comedy" },
            new SelectListItem { Text = "Sci-Fi", Value = "sci-fi" },
            new SelectListItem { Text = "Fantasy", Value = "fantasy" }
        };

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var Genres = new List<string>();
            foreach(var item in genres)
            {
                Genres.Add(item.Value);
            }
            if (!Genres.Contains(Genre))
            {
                yield return new ValidationResult(
                    $"No such genre.",
                    new[] { nameof(Genre) });
            }
        }

        public override string ToString()
        {
            if (Director != null)
            {
                return Director.ToString();
            }
            return "asdf";
        }
    }

}
