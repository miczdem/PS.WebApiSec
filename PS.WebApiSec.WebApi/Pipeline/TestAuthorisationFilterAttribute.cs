using System.Web.Http;
using System.Web.Http.Controllers;

namespace PS.WebApiSec.WebApi.Pipeline
{
    public class TestAuthorisationFilterAttribute : AuthorizeAttribute
    {
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            Helper.Write("AuthorisationFilter", actionContext.RequestContext.Principal);
            return true; //base.IsAuthorized(actionContext);
        }
    }
}