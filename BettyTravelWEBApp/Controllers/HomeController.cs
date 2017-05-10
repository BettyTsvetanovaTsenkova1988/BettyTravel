using System.Collections.Generic;
using System.Web.Mvc;
using BettyTravel.Services;
using BettyTravelApp.Models.ViewModels.Vacation;

namespace BettyTravelApp.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("home")]
    public class HomeController : Controller
    {
        private HomeService service;

        public HomeController()
        {
            this.service = new HomeService();
        }


        [Route("index")]
        [HttpGet]
        public ActionResult Index()
        {
            IEnumerable<AllVacationsViewModel> allVacations = this.service.GetAllVacations();
            return View(allVacations);
        }

        [HttpGet]
        [Route("about")]
        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        [Route("contact")]
        public ActionResult Contact()
        {
            return View();
        }
    }
}