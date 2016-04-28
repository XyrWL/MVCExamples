using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sandbox.Models;

namespace Sandbox.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            return View(new FirstModel());
        }

        // POST: First
        [HttpPost]
        public ActionResult Index(FirstModel model)
        {
            if (model.IsWinner())
                ViewBag.Result = "You win.";
            ModelState.Remove("CurrentValue");
            return View(model);
        }
    }
}