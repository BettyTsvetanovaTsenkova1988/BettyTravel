using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BettyTravelApp.Models.EntityModels;


namespace BettyTravel.Services
{
    public class AccountService : Service
    {
        public void CreateCustomer(ApplicationUser user)
        {
            Customer customer = new Customer();
            ApplicationUser currUser = this.Context.Users.Find(user.Id);
            customer.User = currUser;
            this.Context.Customers.Add(customer);
            this.Context.SaveChanges();
        }
    }
}
