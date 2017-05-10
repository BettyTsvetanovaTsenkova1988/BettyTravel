using System.Collections.Generic;
using AutoMapper;
using BettyTravelApp.Models.EntityModels;
using BettyTravelApp.Models.ViewModels.Vacation;

namespace BettyTravel.Services
{
    public class HomeService : Service
    {
        public IEnumerable<AllVacationsViewModel> GetAllVacations()
        {
            IEnumerable<Vacation> vacations = this.Context.Vacations;
            IEnumerable<AllVacationsViewModel> allVacations =
                Mapper.Map<IEnumerable<Vacation>, IEnumerable<AllVacationsViewModel>>(vacations);
            return allVacations;

        }
    }
}
