using System.Net.Http;
using System.Web.Http;

namespace PS.WebApiSec.WebApi.Pipeline
{
    [TestAuthenticationFilter]
    [TestAuthorisationFilter]
    public class TestController: ApiController
    {

        public IHttpActionResult Get()
        {
            Helper.Write("Controller",User);
            return Ok();
        }
    }
}