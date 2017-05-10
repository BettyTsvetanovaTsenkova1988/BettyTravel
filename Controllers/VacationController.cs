using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BettyTravel.Services;
using BettyTravelApp.Models.EntityModels;
using BettyTravelApp.Models.ViewModels.Vacation;

namespace BettyTravelApp.Controllers
{
    [RoutePrefix("vacations")]
    [AllowAnonymous]
    public class VacationController : Controller
    {
        private VacationService service;

        public VacationController()
        {
            this.service = new VacationService();
        }


        [HttpGet, Route("details/{id}")]
        public ActionResult Details(int id)
        {
            if (id <= 0)
            {
                return this.View("VacationNotFound");
            }

            VacationDetailsViewModel vm = this.service.GetDetails(id);
            if (vm == null)
            {
                return this.View("VacationNotFound");
            }

            return this.View(vm);
        }

        [HttpPost]
        [Authorize(Roles = "admin, customer")]
        [Route("buyVacation")]
        public ActionResult BuyVacation(int vacationId)
        {
            try
            {
                string customerName = this.User.Identity.Name;
                Customer customer = this.service.GetCurrentCustomer(customerName);
                this.service.BuyVacation(vacationId, customer);
                return this.RedirectToAction("Profile", "Customers");
            }
            catch (Exception)
            {

                return this.View("Error");
            }


        }


    }
}