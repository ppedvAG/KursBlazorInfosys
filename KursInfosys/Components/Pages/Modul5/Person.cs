using System.ComponentModel.DataAnnotations;

namespace KursInfosys.Components.Pages.Modul5
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Vorname ist erforderlich.")]
        [StringLength(10,MinimumLength =3, ErrorMessage = "Vorname muss zwischen 3 und 10 Zeichen lang sein.")]
        public string FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Bitte füllen")]
        [Range(120,190, ErrorMessage = "Bitte füllen Sie die Größe zwischen 120 und 190 cm ein.")]
        public int Gross { get; set; }
        [Required(ErrorMessage = "Füllen")]
        public DateOnly GebDat { get; set; }
    }
}
