using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjektASP.Models
{
    public class Director
    {
        public int Id { get; set; }
        [DisplayName("Imię")]
        public string? Name { get; set; }
        [DisplayName("Nazwisko")]
        public string? LastName { get; set; }

        [DisplayName("Data urodzenia")]
        [DataType(DataType.Date)]
        public DateTime Born { get; set; }

        public IEnumerable<Movie> Movies { get; set; }

        public override string ToString()
        {
            return $"{Id}, {"Name"}";
        }
    }
}
