using System;
using System.ComponentModel.DataAnnotations;

namespace CiphersDemo.ViewModels
{
    public class CaesarCipherViewModel
    {
        [Required]
        [Display(Name = "Type your text to encrypt here:")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Use English alphabet only")]
        public string InputText { get; set; }

        [Required]
        [Range(1, 25, ErrorMessage = "Use shift in range from 1 to 25")]
        public int Shift { get; set; }

        [Display(Name = "Encrypted text:")]
        public string OutputText { get; set; }
    }
}
