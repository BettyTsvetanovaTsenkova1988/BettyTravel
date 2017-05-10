using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BettyTravelApp.Models.BindingModels;
using BettyTravelApp.Models.EntityModels;
using BettyTravelApp.Models.ViewModels.Admin;

namespace BettyTravel.Services
{
    public class AdminService : Service
    {
        private const string PicturePath = "\\Content\\images\\upload\\";
        public IEnumerable<VacationVM> GetAllVacations()
        {
            IEnumerable<Vacation> vacations = this.Context.Vacations;
            IEnumerable<VacationVM> vacationVM = Mapper.Map<IEnumerable<Vacation>, IEnumerable<VacationVM>>(vacations);
            return vacationVM;
        }

        public VacationCRUDvm GetDetails(int? id)
        {
            Vacation vacation = this.Context.Vacations.Find(id);
            VacationCRUDvm vm = Mapper.Map<Vacation, VacationCRUDvm>(vacation);
            return vm;
        }

        public void CreateVacation(VacationBM bind)
        {
            Vacation vacation = new Vacation();
            vacation.VacationName = bind.VacationName;
            vacation.VacationDescription = bind.VacationDescription;
            vacation.Price = bind.Price;
            vacation.StartPeriod = bind.StartPeriod;
            vacation.EndPeriod = bind.EndPeriod;
            vacation.TransportType = bind.TransportType;
            vacation.FeedingType = bind.FeedingType;
            vacation.Picures = new List<Picure>();

            if (bind.Picture1 != null)
            {
                vacation.Picures.Add(
               new Picure()
               {
                   PictureSourse = PicturePath + bind.Picture1
               });
            }

            if (bind.Picture2 != null)
            {
                vacation.Picures.Add(new Picure()
                {
                    PictureSourse = PicturePath + bind.Picture2
                });
            }

            if (bind.Picture3 != null)
            {
                vacation.Picures.Add(new Picure()
                {
                    PictureSourse = PicturePath + bind.Picture3
                });
            }

            if (bind.Picture4 != null)
            {
                vacation.Picures.Add(new Picure()
                {
                    PictureSourse = PicturePath + bind.Picture4
                });
            }

            this.Context.Vacations.Add(vacation);
            this.Context.SaveChanges();
        }

        public void CheckState(VacationCRUDvm vm)
        {
            Vacation vacation = Mapper.Map<VacationCRUDvm, Vacation>(vm);
            this.Context.Entry(vacation).State = EntityState.Modified;
            this.Context.SaveChanges();
        }

        public void RemoveVacation(VacationCRUDvm vm)
        {
            Vacation vacation = this.Context.Vacations.FirstOrDefault(v => v.Id == vm.Id);
            vacation.Picures.Clear();
            vacation.Customers.Clear();
            vacation.Reservations.Clear();
            this.Context.Vacations.Remove(vacation);
            this.Context.SaveChanges();
        }

        public void Despose()
        {
            this.Context.Dispose();
        }

        public AdminAditionalDataVM GetAllReservations()
        {
            Customer admin = this.Context.Customers.FirstOrDefault(c => c.User.Id == "820d07ff-1be4-4709-9669-36e755e65478");
            AdminAditionalDataVM vm = Mapper.Map<Customer, AdminAditionalDataVM>(admin);
            return vm;
        }
    }
}
