using ProjektASP.Migrations;
using ProjektASP.Models;
using System.ComponentModel.DataAnnotations;

namespace ProjektASP.Models
{
    public class OldMovieAttribute : ValidationAttribute
    {
        public OldMovieAttribute(int year)
            => Year = year;

        public int Year { get; }

        public string GetErrorMessage() =>
            $"Filmy nie mogą mieć wcześniejszego roku produkcji niż {Year}.";

        protected override ValidationResult? IsValid(
            object? value, ValidationContext validationContext)
        {
            var releaseYear = ((DateTime)value!).Year;

            if (releaseYear < Year)
            {
                return new ValidationResult(GetErrorMessage());
            }

            return ValidationResult.Success;
        }
    }
}

