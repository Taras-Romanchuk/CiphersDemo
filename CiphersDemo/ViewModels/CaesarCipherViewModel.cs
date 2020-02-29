using System.ComponentModel.DataAnnotations;

namespace CiphersDemo.ViewModels
{
    public class CaesarCipherViewModel
    {
        [Required]
        [Display(Name = "Type your text to encrypt here:")]
        [RegularExpression(@"^[A-Z\s]+$", ErrorMessage = "Use English alphabet uppercase only")]
        public string InputText { get; set; }

        [Required]
        [Range(1, 25, ErrorMessage = "Use shift in range from 1 to 25")]
        public int Shift { get; set; }

        [Display(Name = "Encrypted text:")]
        public string OutputText { get; set; }
    }
}
