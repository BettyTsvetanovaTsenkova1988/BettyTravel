using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BettyTravelApp.Models.EntityModels;

namespace BettyTravel.Services
{
    public class CustomerService : Service
    {
        public Customer GetCurrentCustomer(string customerName)
        {
            var currCustomer = this.Context.Users.FirstOrDefault(c => c.Name == customerName);
            Customer customer = this.Context.Customers.FirstOrDefault(cc => cc.User.Id == currCustomer.Id);
            return customer;
        }

        public void BuyVacation(int vacationId, Customer customer)
        {
            Vacation vacation = this.Context.Vacations.Find(vacationId);
            var reservation = new Reservation();
            reservation.Vacation = vacation;
            customer.Reservations.Add(reservation);
           // customer.Vacations.Add(vacation);
            this.Context.SaveChanges();
        }
    }
}
