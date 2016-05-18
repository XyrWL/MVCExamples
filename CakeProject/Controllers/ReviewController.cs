using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CakeProject.Models;

namespace CakeProject.Controllers
{
    public class ReviewController : Controller
    {
        // GET: Add
        public ActionResult Add()
        {
            return View(new ReviewModel());
        }

        // POST: Add
        [HttpPost]
        public ActionResult Add(ReviewModel model)
        {
            if (ModelState.IsValid)
                return View("Added");
            return View(l);
        }
    }
}