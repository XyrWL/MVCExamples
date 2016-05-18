using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxWebProject.Models;

namespace AjaxWebProject.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Details()
        {
            var person = new Person { ID = 0, Name = "Freddie", BirthDate = new DateTime(year: 1977, month: 01, day: 15) };
            return View(person);
        }

        public string HitMe()
        {
            return "Pow! Punch! -";
        }
    }
}