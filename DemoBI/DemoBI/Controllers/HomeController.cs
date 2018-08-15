using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoBI.Controllers
{
    public class HomeController : Controller
    {
        public object ResourceUrl { get; }
        public object AuthorityUrl { get; private set; }

        public ActionResult CredentialCreator()
        {

        // Create a user password cradentials.
        var credential = new UserPasswordCredential(Username, Password);

        // Authenticate using created credentials
        var authenticationContext = new AuthenticationContext(AuthorityUrl);
        var authenticationResult = await authenticationContext.AcquireTokenAsync(ResourceUrl, ClientId, credential);

if (authenticationResult == null)
{
    return View(new EmbedConfig()
        {
            ErrorMessage = "Authentication Failed."
    });
}

    var tokenCredentials = new TokenCredentials(authenticationResult.AccessToken, "Bearer");
}
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}