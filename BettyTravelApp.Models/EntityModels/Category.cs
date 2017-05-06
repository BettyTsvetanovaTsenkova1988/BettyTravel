using System.Collections.Generic;
using BettyTravelApp.Models.Enumerations;

namespace BettyTravelApp.Models.EntityModels
{
    public class Category : ApplicationUser
    {
        private ICollection<Vacation> vacations;

        public Category()
        {
            this.vacations = new HashSet<Vacation>();
        }
        public int Id { get; set; }
        public CategoryType CategoryName { get; set; }

        public virtual ICollection<Vacation> Vacations
        {
            get { return this.vacations; }
            set { this.vacations = value; }

        }

    }
}
