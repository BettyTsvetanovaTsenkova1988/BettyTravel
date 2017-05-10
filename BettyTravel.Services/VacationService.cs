using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BettyTravelApp.Models.EntityModels;
using BettyTravelApp.Models.ViewModels.Vacation;
using Microsoft.VisualBasic.ApplicationServices;

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


        public Customer GetCurrentCustomer(string customerName)
        {
            var user = this.Context.Users.FirstOrDefault(appicationUser => appicationUser.UserName == customerName);
            Customer customer = this.Context.Customers.FirstOrDefault(cc => cc.User.Id == user.Id);
            return customer;
        }


        public void BuyVacation(int vacationId, Customer customer)
        {
            Vacation wantedDacation = this.Context.Vacations.Find(vacationId);
            customer.Vacations.Add(wantedDacation);
            this.Context.SaveChanges();
            this.SendConfirmationToAdmin(wantedDacation, customer);
        }

        private void SendConfirmationToAdmin(Vacation wantedDacation, Customer customer)
        {
            var user = this.Context.Users.FirstOrDefault(appicationUser => appicationUser.Id == "820d07ff-1be4-4709-9669-36e755e65478");
            Customer admin = this.Context.Customers.FirstOrDefault(cc => cc.User.Id == user.Id);

            string reservation =
                string.Format($"Е-мейл на потребител - {customer.User.UserName}, име на резервацията - {wantedDacation.VacationName}, цена - {wantedDacation.Price}");

            admin.AdditionalData.Add(reservation);
            this.Context.Entry(admin).State = EntityState.Modified;
            this.Context.SaveChanges();

        }
    }
}
