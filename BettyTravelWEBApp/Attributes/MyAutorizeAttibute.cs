using System.Linq;
using System.Web.Mvc;

namespace BettyTravelApp.Attributes
{
    public class MyAutorizeAttibute : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Request.IsAuthenticated &&
                 !this.Roles.Split(',').Any(filterContext.HttpContext.User.IsInRole))
            {
                filterContext.Result = new ViewResult()
                {
                    ViewName = "~/Views/Shared/Unauthorized.cshtml"
                };

            }
            else
            {
                base.HandleUnauthorizedRequest(filterContext);
            }
        }
    }
}