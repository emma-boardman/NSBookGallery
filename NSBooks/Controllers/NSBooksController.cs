using System;
using System.Web.Mvc;
using NSBooks.Models;

namespace NSBooks.Controllers
{
    public class NSBooksController : Controller
    {
     
        public ActionResult Detail()

        {
            var nsBook = new NSBook()

            {
                SeriesTitle = "Kanji Practice",
                JlptLevel = 4,
                DescriptionHtml = "<b>Info Info Info</b>",
                Authors = new Author[]
                {
                    new Author() { Name = "Writer 1", Role = "Writing 1"},
                    new Author() { Name = "Writer 2", Role = "Writing 2"}
                }
            };

            return View(nsBook);
        }
    }
}
