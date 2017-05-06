using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettyTravelApp.Models.EntityModels
{
    public class Customer
    {
        private ICollection<Reservation> reservations;


        public Customer()
        {
            this.reservations = new HashSet<Reservation>();
        }
        public int Id { get; set; }

        public virtual ICollection<Reservation> Reservations
        {
            get { return this.reservations; }
            set { this.reservations = value; }
        }
        public virtual ApplicationUser User { get; set; }//hold the reference to the application user and it's properties


    }
}