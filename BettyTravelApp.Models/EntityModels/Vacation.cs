using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BettyTravelApp.Models.Enumerations;

namespace BettyTravelApp.Models.EntityModels
{
    public class Vacation
    {
        private ICollection<Picure> picures;
        private ICollection<Reservation> reservations;
        private ICollection<Customer> customers;

        public Vacation()
        {
            this.picures = new HashSet<Picure>();
            this.reservations = new HashSet<Reservation>();
            this.customers = new HashSet<Customer>();
        }
        public int Id { get; set; }
        public string VacationName { get; set; }
        public string VacationDescription { get; set; }
        public virtual Category Category { get; set; }
        public decimal Price { get; set; }
        public DateTime StartPeriod { get; set; }//when the holiday is open for reservations
        public DateTime EndPeriod { get; set; }//when the holiday is closed for reservations

        [InverseProperty("Vacations")]
        public virtual ICollection<Customer> Customers
        {
            get { return this.customers; }
            set { this.customers = value; }
        }
        public virtual ICollection<Picure> Picures
        {
            get { return this.picures; }
            set { this.picures = value; }
        }

        public TransportType TransportType { get; set; }
        public FeedingType FeedingType { get; set; }

        public virtual ICollection<Reservation> Reservations
        {
            get { return this.reservations; }
            set { this.reservations = value; }
        }

    }
}
