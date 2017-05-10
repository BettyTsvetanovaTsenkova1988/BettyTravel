using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using BettyTravelApp.Models.EntityModels;
using BettyTravelApp.Models.ViewModels.Admin;
using BettyTravelApp.Models.ViewModels.Customers;
using BettyTravelApp.Models.ViewModels.Vacation;

namespace BettyTravelApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ConfigureMappings();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void ConfigureMappings()
        {
            Mapper.Initialize(exp =>
            {
                exp.CreateMap<Vacation, AllVacationsViewModel>();
                exp.CreateMap<Vacation, VacationDetailsViewModel>();
                exp.CreateMap<ApplicationUser, CustomerProfileViewModel>();
                exp.CreateMap<Vacation, CustomerVacationViewModel>();
                exp.CreateMap<Customer, CustomerProfileViewModel>();
                exp.CreateMap<ApplicationUser, EditCustomerViewModel>();
                exp.CreateMap<Vacation, VacationVM>();
                exp.CreateMap<Vacation, VacationCRUDvm>();
                exp.CreateMap<VacationCRUDvm, Vacation>();
                exp.CreateMap<Customer, AdminAditionalDataVM>();
            });
        }
    }
}
