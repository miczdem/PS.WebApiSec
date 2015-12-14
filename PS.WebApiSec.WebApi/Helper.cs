using System.Diagnostics;
using System.Security.Principal;

namespace PS.WebApiSec.WebApi
{
    public static class Helper
    {
        public static void Write(string stage, IPrincipal principle)
        {
            Debug.WriteLine("-----" + stage + "------");
            if (principle?.Identity == null || 
                !principle.Identity.IsAuthenticated)
            {
                Debug.WriteLine("anonymous user");
            }
            else
            {
                Debug.WriteLine("User: " + principle.Identity.Name);
            }
            Debug.WriteLine("\n");
        }
    }
}