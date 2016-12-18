using System.Net;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Epam.TravixTest.WebService.ActionFilters
{
    /// <summary>
    /// ValidationActionFilter for validation input models in api controllers and reject if not valid.
    /// </summary>
    public class ValidationActionFilter : ActionFilterAttribute
    {
        /// <summary>
        /// OnActionExecuting runs before action method in controllers  
        /// </summary>
        /// <param name="actionContext"></param>
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            var modelState = actionContext.ModelState;

            if (!modelState.IsValid)
                actionContext.Response = actionContext.Request
                     .CreateErrorResponse(HttpStatusCode.BadRequest, modelState);
        }
    }
}