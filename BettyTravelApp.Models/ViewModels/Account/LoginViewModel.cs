using System.ComponentModel.DataAnnotations;

namespace BettyTravelApp.Models.ViewModels.Account
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Е-мейл")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Парола")]
        public string Password { get; set; }

        [Display(Name = "Запомняне?")]
        public bool RememberMe { get; set; }
    }
}
