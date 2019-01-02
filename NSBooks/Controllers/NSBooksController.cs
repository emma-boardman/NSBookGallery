using System;
using System.Web.Mvc;
using NSBooks.Data;
using NSBooks.Models;

namespace NSBooks.Controllers
{
    public class NSBooksController : Controller
    {

        private NSBookRepo _nsBookRepo = null;

        public NSBooksController()
        {
            _nsBookRepo = new NSBookRepo();
        }


        public ActionResult List()

        {

            var nsBooks = _nsBookRepo.GetNSBooks();
            return View(nsBooks);

          
        }

        public ActionResult Detail(int? id)

        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var nsBook = _nsBookRepo.GetNSBook(id.Value);

           
            return View(nsBook);
        }

       
    }
}
