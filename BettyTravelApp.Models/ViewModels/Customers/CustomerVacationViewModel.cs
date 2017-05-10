using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettyTravelApp.Models.ViewModels.Customers
{
    public class CustomerVacationViewModel
    {
        public int Id { get; set; }
        public string VacationName { get; set; }
        public decimal Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
