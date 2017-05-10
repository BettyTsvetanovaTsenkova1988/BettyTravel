using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BettyTravel.Services;
using BettyTravelApp.Models.BindingModels;
using BettyTravelApp.Models.EntityModels;
using BettyTravelApp.Models.ViewModels.Customers;

namespace BettyTravelApp.Controllers
{
    [RoutePrefix("customers")]
    [Authorize(Roles = "admin, customer")]
    public class CustomersController : Controller
    {
        private CustomerService service;

        public CustomersController()
        {
            this.service = new CustomerService();
        }


        [HttpGet]
        [Route("profile")]
        public ActionResult Profile()
        {
            string customerName = this.User.Identity.Name;
            CustomerProfileViewModel vm = this.service.GetProfileVm(customerName);

            return this.View(vm);
        }

        [HttpGet]
        [Route("edit")]
        public ActionResult Edit()
        {
            string customerName = this.User.Identity.Name;
            EditCustomerViewModel vm = this.service.GetEditVm(customerName);
            return this.View(vm);
        }

        [HttpPost]
        [Route("edit")]
        public ActionResult Edit(EditCustomerBM bind)
        {
            if (this.ModelState.IsValid)
            {
                string currUsername = this.User.Identity.Name;
                this.service.EditUser(bind, currUsername);

                return this.RedirectToAction("Profile");
            }
            string customerName = this.User.Identity.Name;
            EditCustomerViewModel vm = this.service.GetEditVm(customerName);

            return this.View(vm);
        }

        [HttpGet]
        public ActionResult Remove(int? id)
        {
            Vacation vm = this.service.GetVacation(id);

            if (vm == null)
            {
                return this.View("VacationNotFound");
            }

            return this.View(vm);
        }

        [HttpPost, ActionName("Remove")]
        public ActionResult RemoveConfirmed(int id)
        {
            if (id <= 0)
            {
                this.View("VacationNotFound");
            }
            string currUsername = this.User.Identity.Name;
            this.service.RemoveVacation(id, currUsername);

            return this.RedirectToAction("Profile", "Customers");
        }
    }
}