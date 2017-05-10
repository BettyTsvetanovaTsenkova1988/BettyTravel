using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettyTravelApp.Models.EntityModels
{
    public class Customer
    {
        private ICollection<Reservation> reservations;
        private ICollection<Vacation> vacations;
        private ICollection<string> additionalData;

        public int Id { get; set; }

        public Customer()
        {
            this.reservations = new HashSet<Reservation>();
            this.vacations = new HashSet<Vacation>();
            this.additionalData = new List<string>();
        }

        [InverseProperty("Customers")]
        public virtual ICollection<Vacation> Vacations
        {
            get { return this.vacations; }
            set { this.vacations = value; }
        }

        public ICollection<string> AdditionalData
        {
            get { return this.additionalData; }
            set { this.additionalData = value; }
        }

        public virtual ICollection<Reservation> Reservations
        {
            get { return this.reservations; }
            set { this.reservations = value; }
        }

        public virtual ApplicationUser User { get; set; }//hold the reference to the application user and it's properties


    }
}