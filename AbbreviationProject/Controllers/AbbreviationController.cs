using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AbbreviationProject.Models;

namespace AbbreviationProject.Controllers
{
    public class AbbreviationController : Controller
    {
        // GET: Display
        public ActionResult Display()
        {
            return View(AbbreviationModel.CreateExample());
        }

        // GET: List
        public ActionResult List()
        {
            return View(AbbreviationModel.CreateDummyList());
        }

        // GET: AutoList
        public ActionResult AutoList()
        {
            return View(AbbreviationModel.CreateDummyList());
        }
    }
}