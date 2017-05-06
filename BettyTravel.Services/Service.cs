using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BettyTravel.Data;

namespace BettyTravel.Services
{
    public abstract class Service //this class hold the DB
    {
        public Service()
        {
            this.Context= new BettyTravelContext();
        }

        protected BettyTravelContext Context { get; }
    }
}
