using BettyTravelApp.Models;
using BettyTravelApp.Models.EntityModels;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BettyTravel.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BettyTravelContext : IdentityDbContext<ApplicationUser>
    {

        public BettyTravelContext()
            : base("data source=HOME\\SQLSERVER;initial catalog=BettyTravelDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Picure> Picures { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Vacation> Vacations { get; set; }

        public static BettyTravelContext Create()
        {
            return new BettyTravelContext();
        }


    }
}