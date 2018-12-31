using System;
using System.Web.Mvc;

namespace NSBooks.Controllers
{
    public class NSBooksController : Controller
    {
     
        public ActionResult Detail()

        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                return Redirect("/");
            }

            return Content("Hello from NS Books Controller");
           
        }
    }
}
