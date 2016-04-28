using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaramelProject.Models;

namespace CaramelProject.Controllers
{
    public class CaramelController : Controller
    {
        // GET: Caramel
        public ActionResult Details()
        {
            var details = new CaramelDetailsModel
            {
                Name = "a caramel",
                Ingredients = new[] { "Sugar", "More sugar", "Milk", "Butter", "Vanilla" }
            };
            return View(details);
        }
    }
}