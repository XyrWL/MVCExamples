using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RazorProject.Models;

namespace RazorProject.Controllers
{
    public class RecipeController : Controller
    {
        // GET: Recipe
        public ActionResult FullDetails()
        {
            var recipe = new RecipeDetailsModel
            {
                Name = "Tigerkaka",
                Ingredients = "2 ägg, 3dl socker, 3dl vetemjöl, 1tsk bakpulver, 1tsk vanilinsocker, 1msk kakao, 1/2dl vatten och 150g smör.",
                Instructions = "Baka den.",
                Difficulty = 2
            };
            return View(recipe);
        }
    }
}