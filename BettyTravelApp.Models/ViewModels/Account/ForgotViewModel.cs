using System.ComponentModel.DataAnnotations;

namespace BettyTravelApp.Models.ViewModels.Account
{
  public  class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
