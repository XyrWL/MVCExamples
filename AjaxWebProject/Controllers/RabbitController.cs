using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxWebProject.Models;

namespace AjaxWebProject.Controllers
{
    public class RabbitController : Controller
    {
        public ActionResult Details()
        {
            var rabbit = new Rabbit
            {
                ID = 666,
                BirthDate = new DateTime(year: 2006, month: 06, day: 06),
                AngerLevel = 9001,
                Name = "Honeybunny",
                Grudges = new List<Grudge>
                {
                    new Grudge {ID = 7, TargetName = "Innocent rabbits", Reason = "ADHD"},
                    new Grudge {ID = 8, TargetName = "People", Reason = "Snitch"}
                }
            };
            Session["Rabbit"] = rabbit; //Should be saved to DB instead.
            return View(rabbit);
        }
    }
}