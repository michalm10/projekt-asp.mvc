using System.ComponentModel.DataAnnotations;
using ProjektASP.Models.Identity;

namespace ProjektASP.Models
{
    public class Rating
    {
        public int Id { get; set; } 
        public int? MovieId { get; set; }

        public Movie? Movie { get; set; }
        public string? UserId { get; set; }

        public AppUser? User { get; set; }

        [Range(1, 10)]
        public short? rating { get; set; }
    }
}
