using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Owin;

namespace PS.WebApiSec.WebApi.Pipeline
{
    public class TestMiddleware
    {
        private Func<IDictionary<string, object>, Task> _next;

        public TestMiddleware(Func<IDictionary<string, object> ,Task> next)
        {
            _next = next;
        }

        public async Task Invoke(IDictionary<string, object> env)
        {
            //"server.user" is the key for the principal in the dictionary, or use the OwinContext wrapper
            var context = new OwinContext(env);

            // authentication
            context.Request.User = new GenericPrincipal(
                new GenericIdentity("dummy"),new string [] {} );

            Helper.Write("Middleware", context.Request.User);
            await _next(env);
        }
    }
}