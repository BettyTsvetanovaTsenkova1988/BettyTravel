using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BettyTravelApp.Models.EntityModels;

namespace BettyTravelApp.Models.ViewModels.Customers
{
    public class CustomerProfileViewModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public IEnumerable<CustomerVacationViewModel> Vacations { get; set; }

    }
}
