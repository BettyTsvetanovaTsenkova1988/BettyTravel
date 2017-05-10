using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BettyTravelApp.Models.EntityModels;
using BettyTravelApp.Models.Enumerations;

namespace BettyTravelApp.Models.BindingModels
{
    public class VacationBM
    {
        [Display(Name = "Дестинация")]
        public string VacationName { get; set; }

        [Display(Name = "Описание")]
        public string VacationDescription { get; set; }

        [Display(Name = "Цена")]
        public decimal Price { get; set; }

        [Display(Name = "Начална дата")]
        public DateTime StartPeriod { get; set; }

        [Display(Name = "Крайна дата")]
        public DateTime EndPeriod { get; set; }

        [Display(Name = "Транспорт")]
        public TransportType TransportType { get; set; }

        [Display(Name = "Изхранване")]
        public FeedingType FeedingType { get; set; }

        public string Picture1 { get; set; }
        public string Picture2 { get; set; }
        public string Picture3 { get; set; }
        public string Picture4 { get; set; }
    }
}
