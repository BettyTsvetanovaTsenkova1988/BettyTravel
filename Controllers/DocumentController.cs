using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BettyTravelApp.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("document")]
    public class DocumentController : Controller
    {
     
        [HttpGet]
        [Route("all")]
        public ActionResult All()
        {
            return View();
        }
    }
}