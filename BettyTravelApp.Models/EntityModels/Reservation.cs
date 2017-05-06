using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettyTravelApp.Models.EntityModels
{
  public  class Reservation
    {
        public int Id { get; set; }
        public virtual Customer Customer { get; set; }//the name of the customer who makes the reservation
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual Vacation Vacation { get; set; }
        public int NumberOfVisitors { get; set; }
    }
}
