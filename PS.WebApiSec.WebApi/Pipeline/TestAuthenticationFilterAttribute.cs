using System;
using System.Net.Http;
using System.Security.Policy;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Filters;

namespace PS.WebApiSec.WebApi.Pipeline
{
    public class TestAuthenticationFilterAttribute : Attribute, IAuthenticationFilter
    {
        public bool AllowMultiple => false;

        public async Task AuthenticateAsync(HttpAuthenticationContext context, CancellationToken cancellationToken)
        {
            Helper.Write("AuthenticateAsync", context.ActionContext.RequestContext.Principal);

        }

        public async Task ChallengeAsync(HttpAuthenticationChallengeContext context, CancellationToken cancellationToken)
        {
            
        }
    }
}