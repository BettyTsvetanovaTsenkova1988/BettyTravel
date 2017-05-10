using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BettyTravelApp.Models.BindingModels;
using BettyTravelApp.Models.EntityModels;
using BettyTravelApp.Models.ViewModels.Customers;

namespace BettyTravel.Services
{
    public class CustomerService : Service
    {
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
        }

        public CustomerProfileViewModel GetProfileVm(string customerName)
        {
            ApplicationUser currUser = this.Context.Users.FirstOrDefault(user => user.UserName == customerName);
            Customer currCustomer = this.Context.Customers.FirstOrDefault(c => c.User.Id == currUser.Id);
            var vacations =
               Mapper.Map<IEnumerable<Vacation>, IEnumerable<CustomerVacationViewModel>>(currCustomer.Vacations);
            CustomerProfileViewModel vm = Mapper.Map<Customer, CustomerProfileViewModel>(currCustomer);
            vm.Vacations = vacations;


            return vm;
        }

        public EditCustomerViewModel GetEditVm(string customerName)
        {
            ApplicationUser user = this.Context.Users.FirstOrDefault(apuser => apuser.UserName == customerName);
            EditCustomerViewModel vm = Mapper.Map<ApplicationUser, EditCustomerViewModel>(user);

            return vm;
        }

        public void EditUser(EditCustomerBM bind, string currUsername)
        {
            ApplicationUser user = this.Context.Users.FirstOrDefault(apuser => apuser.UserName == currUsername);
            user.Name = bind.Name;
            user.Email = bind.Email;
            user.UserName = bind.Email;
            this.Context.SaveChanges();
        }

        public void RemoveVacation(int id, string currUsername)
        {
            ApplicationUser user = this.Context.Users.FirstOrDefault(apuser => apuser.UserName == currUsername);
            Customer customer = this.Context.Customers.FirstOrDefault(c => c.User.UserName == currUsername);
            Vacation vacation = this.Context.Vacations.FirstOrDefault(v => v.Id == id);
            customer.Vacations.Remove(vacation);
            this.Context.SaveChanges();
        }

        public Vacation GetVacation(int? id)
        {
            Vacation vacation = this.Context.Vacations.FirstOrDefault(v => v.Id == id);
            return vacation;
        }
    }
}
