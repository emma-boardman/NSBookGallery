using System;
using System.Web.Mvc;

namespace NSBooks.Controllers
{
    public class NSBooksController : Controller
    {
     
        public ActionResult Detail()

        {

            ViewBag.SeriesTitle = "Kanji Practice";
            ViewBag.JlptLevel = 4;
            ViewBag.Description = "<b>Info Info Info</b>";
            ViewBag.Authors = new string[]

                {
                    "Script: Test this isn't a cached value",
                    "Pencils: Humberto Ramos",
                    "Inks: Victor Olazaba",
                    "Colors: Edgar Delgado",
                    "Letters: Chris Eliopoulos"
                };

            return View();
        }
    }
}
