using System.Net.Http;
using System.Web.Http;

namespace PS.WebApiSec.WebApi.Pipeline
{
    public class TestController: ApiController
    {
        public IHttpActionResult Get()
        {
            Helper.Write("Controller",Request.GetRequestContext().Principal);
            Helper.Write("Controller",User);
            return Ok();
        }
    }
}