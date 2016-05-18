using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxWebProject.Models;

namespace AjaxWebProject.Controllers
{
    public class CarController : Controller
    {
        public PartialViewResult _Create(int id)
        {
            var car = new Car {PersonId = id};
            return PartialView(viewName: "_Create", model: car);
        }

        public void _HideCreate(){}
    }
}