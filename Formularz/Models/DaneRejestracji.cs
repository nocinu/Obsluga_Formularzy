using System.ComponentModel.DataAnnotations;

namespace FormularzRejestracji.Models
{
    public class DaneRejestracji
    {
        [Required(ErrorMessage = "Prosze podaj Imie")]
        [StringLength(30, MinimumLength = 2,
            ErrorMessage = "Imie musi mieć minimum 2 znaki")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Prosze podaj Nazwisko")]
        [StringLength(50, MinimumLength = 2,
            ErrorMessage = "Nazwisko musi mieć minimum 2 znaki")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Prosze podaj Email")]
        [EmailAddress(ErrorMessage = "Podaj poprawny adres email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Prosze podaj Haslo")]
        [StringLength(100, MinimumLength = 8,
            ErrorMessage = "Haslo musi miec co najmniej 8 znakow")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$",
            ErrorMessage = "Haslo musi zawierac co najmniej jedna cyfra, jedna duza litera i jedna mala litera")]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Prosze potwierdz Haslo")]
        [DataType(DataType.Password)]
        [Compare("Haslo", ErrorMessage = "Hasla nie pasuja")]
        public string PotwierdzenieHasla { get; set; }

        [Required(ErrorMessage = "Prosze podaj Telefon")]
        [Phone(ErrorMessage = "Podaj poprawny numer telefonu")]
        public string Telefon { get; set; }

        [Required(ErrorMessage = "Prosze podaj Wiek")]
        [Range(10, 80, ErrorMessage = "Wiek musi byc miedzy 10 a 80 lat")]
        public int Wiek { get; set; }

        [Required(ErrorMessage = "Prosze podaj Miasto")]
        public string Miasto { get; set; }

        public enum Miasta
        {
            Warszawa = 1,
            Kraków = 2,
            Wrocław = 3,
            Poznań = 4,
            Gdańsk = 5
        }
    }
}