using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BettyTravelApp.Models.EntityModels;
using BettyTravelApp.Models.ViewModels.Vacation;

namespace BettyTravel.Services
{
    public class VacationService : Service
    {
        public VacationDetailsViewModel GetDetails(int id)
        {
            Vacation vacation = this.Context.Vacations.Find(id);

            if (vacation == null)
            {
                return null;
            }

            VacationDetailsViewModel vm = Mapper.Map<Vacation, VacationDetailsViewModel>(vacation);
            return vm;
        }
    }
}
