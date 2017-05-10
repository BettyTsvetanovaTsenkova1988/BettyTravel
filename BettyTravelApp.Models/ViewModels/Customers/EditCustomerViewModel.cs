using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettyTravelApp.Models.ViewModels.Customers
{
    public class EditCustomerViewModel
    {
       // public int Id { get; set; }
        [Required]
        [Display(Name = "Име")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Е-мейл")]
        public string Email { get; set; }
    }
}
