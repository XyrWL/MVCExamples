using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sandbox.Controllers
{
    public class SecondController : Controller
    {
        // GET: Second
        public ActionResult Index()
        {
            return View();
        }

        // POST: Second
        [HttpPost]
        public ActionResult Index(string coordinate)
        {
            ViewBag.ChosenCoordinate = coordinate;
            return View();
        }
    }
}