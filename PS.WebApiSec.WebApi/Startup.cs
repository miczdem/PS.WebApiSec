using System.Web.Http;
using Microsoft.Owin;
using Owin;
using PS.WebApiSec.WebApi.Pipeline;

[assembly: OwinStartup(typeof(PS.WebApiSec.WebApi.Startup))]

namespace PS.WebApiSec.WebApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var configuration = new HttpConfiguration();
            configuration.Routes.MapHttpRoute(
                "default",
                "api/{controller}");

            app.Use(typeof (TestMiddleware));

            app.UseWebApi(configuration);

        }
    }
}
