using System.ComponentModel.DataAnnotations;

namespace BettyTravelApp.Models.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Е-мейл")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Паролата {0} трябва да съдържа поне {2} символа.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Парола")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Повторете парола")]
        [Compare("Password", ErrorMessage = "Паролата и паролата за потвърждение не съвпадат.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Името {0} трябва да съдържа поне {2} символа.", MinimumLength = 3)]
        [Display(Name = "Име")]
        public string Name { get; set; }
    }
}
