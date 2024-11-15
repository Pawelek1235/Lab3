using System.ComponentModel.DataAnnotations;
#nullable disable
namespace Lab3.Models
{
    public class RejestracjaModel
    {
        [Required]
        public string Imie { get; set; }

        [Required]
        public string Nazwisko { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Haslo { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Haslo", ErrorMessage = "Hasła muszą być identyczne.")]
        public string PotwierdzenieHasla { get; set; }

        [Required]
        [Phone]
        public string NrTelefonu { get; set; }

        [Required]
        [Range(10, 80)]
        public int Wiek { get; set; }

        [Required]
        public Miasto miasto { get; set; }

        // Enum for cities
        public enum Miasto 
        {
            Warszawa,
            Kraków,
            Gdańsk,
            Wrocław,
            Poznań
        }
    }
}
