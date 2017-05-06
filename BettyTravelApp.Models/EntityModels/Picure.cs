using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettyTravelApp.Models.EntityModels
{
    public class Picure
    {
        public int Id { get; set; }
        public string PictureSourse { get; set; }
        public virtual Vacation Vacation { get; set; }
    }
}
