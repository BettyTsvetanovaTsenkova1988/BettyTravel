using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BettyTravelApp.Models.EntityModels;
using BettyTravelApp.Models.Enumerations;

namespace BettyTravelApp.Models.ViewModels.Vacation
{
    public class VacationDetailsViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Място")]
        public string VacationName { get; set; }

        [Display(Name = "Описание")]
        public string VacationDescription { get; set; }

        [Display(Name = "Цена")]
        public decimal Price { get; set; }

        public ICollection<Picure> Picures { get; set; }

        [Display(Name = "Категория")]
        public virtual Category Category { get; set; }

        [Display(Name = "Начална дата на почивката")]
        public DateTime StartPeriod { get; set; }//when the holiday is open for reservations

        [Display(Name = "Крайна дата на почивката")]
        public DateTime EndPeriod { get; set; }//when the holiday is closed for reservations

        [Display(Name = "Вид транспорт")]
        public TransportType TransportType { get; set; }

        [Display(Name = "Тип на изхранването")]
        public FeedingType FeedingType { get; set; }
    }
}
