using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AITech.API.Filters
{
    public class AllowGetRequestsFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.Request.Method == "GET")
            {
                return;
            }
            if (context.HttpContext.User.Identity?.IsAuthenticated != true)
            {
                context.Result = new UnauthorizedResult();
            }
        }
    }
}
