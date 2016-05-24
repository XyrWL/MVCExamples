using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxWebProject.Models;

namespace AjaxWebProject.Controllers
{
    public class GrudgeController : Controller
    {
        // GET: Grudge
        public PartialViewResult _GrudgesForRabbit(int id)
        {
            List<Grudge> grudges = ((Rabbit) Session["Rabbit"]).Grudges;
            return PartialView(grudges);
        }

        public PartialViewResult _Create(int id)
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult _Create(Grudge model)
        {
            ((Rabbit)Session["Rabbit"]).Grudges.Add(model);
            return RedirectToAction(
                actionName: "_GrudgesForRabbit",
                routeValues: new {id = 0});
        }
    }
}