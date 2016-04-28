using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using RazorProject.Models;

namespace RazorProject.Controllers
{
    public class KungFuController : Controller
    {
        // GET: KungFu
        public ActionResult FullDetails()
        {
            var masters = new List<KungFuMaster>
            {
                new KungFuMaster
                {
                    ID = 1,
                    Name = "Keith Kernspecht",
                    Age = 67,
                    KungFuStyle = "Wing Tsun",
                    Level = "Master of comprehension"
                },
                new KungFuMaster
                {
                    ID = 2,
                    Name = "Freddie",
                    Age = 39,
                    KungFuStyle = "Wing Tsun",
                    Level = "12 student grade"
                },
                new KungFuMaster
                {
                    ID = 3,
                    Name = "Emin Boztepe",
                    Age = 56,
                    KungFuStyle = "Wing Tsun",
                    Level = "7 practitioner"
                }
            };
            return View(masters);
        }

        public ActionResult Stars()
        {
            return View();
        }

        public ActionResult StarsSOCad() //ish
        {
            return View();
        }
    }

    public static class ExtensionMethods
    {
        public static string RatingStars(this HtmlHelper helper, int numberOfStars)
        {
            StringBuilder oh = new StringBuilder();
            oh.Append("<span style='color:orange'>");

            for (int i = 0; i < numberOfStars; i++)
            {
                oh.Append("*");
            }
            oh.Append("</span>");
            return oh.ToString();
        }
    }
}