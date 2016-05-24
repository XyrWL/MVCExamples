using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecretProject.Controllers
{
    [Authorize]
    public class SecretController : Controller
    {
        public ContentResult Secret() 
            => Content("Hello this is a secret.");

        [AllowAnonymous]
        public ContentResult Overt()
            => Content("Hello this is not a secret.");
    }
}