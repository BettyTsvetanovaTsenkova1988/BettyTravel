using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BettyTravelApp.Models.EntityModels;

namespace BettyTravelApp.Models.ViewModels.Vacation
{
    public class AllVacationsViewModel
    {
        public int Id { get; set; }
        public string VacationName { get; set; }
        public string VacationDescription { get; set; }
        public decimal Price { get; set; }
        public ICollection<Picure> Picures { get; set; }
        public virtual Category Category { get; set; }

    }
}
