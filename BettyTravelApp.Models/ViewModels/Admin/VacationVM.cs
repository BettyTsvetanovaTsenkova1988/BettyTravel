using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettyTravelApp.Models.ViewModels.Admin
{
    public class VacationVM
    {
        public int Id { get; set; }

        [Display(Name = "Дестинация")]
        public string VacationName { get; set; }

        [Display(Name = "Описание")]
        public string VacationDescription { get; set; }

        [Display(Name = "Цена в лв.")]
        public decimal Price { get; set; }
    }
}
