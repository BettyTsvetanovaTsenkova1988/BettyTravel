using System;
using System.Collections.Generic;
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

        public Vacation()
        {
            this.picures = new HashSet<Picure>();
            this.reservations = new HashSet<Reservation>();
        }
        public int Id { get; set; }
        public string VacationName { get; set; }
        public string VacationDescription { get; set; }
        public virtual Category Category { get; set; }
        public decimal Price { get; set; }
        public DateTime StartPeriod { get; set; }//when the holiday is open for reservations
        public DateTime EndPeriod { get; set; }//when the holiday is closed for reservations

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
