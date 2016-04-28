using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BeerProject.Models;

namespace BeerProject.Controllers
{
    public class BeerController : Controller
    {
        private static List<BeerDetailsModel> beers = new List<BeerDetailsModel>
        {
            new BeerDetailsModel {ID = 1, Name = "Eric", Description = "Soft and smooth", AlcoholVolume=3.5M },
            new BeerDetailsModel {ID = 2, Name = "Mariestad", Description = "Smoky", AlcoholVolume=6.5M },
            new BeerDetailsModel {ID = 3, Name = "Carlsberg", Description = "Blaskig", AlcoholVolume=4.5M }
        };

        // GET: Beer
        public ActionResult List()
        {
            return View(beers);
        }
    }
}