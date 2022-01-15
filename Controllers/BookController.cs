using Microsoft.AspNetCore.Mvc;
using MVC_FormValidation_BookShop.Models;

namespace MVC_FormValidation_BookShop.Controllers
{
    public class BookController : Controller
    {
        public IActionResult AddBook()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            if (ModelState.IsValid)
            {
                Repository.BookList.Add(book);
                ViewBag.Book = book;
                return View("Success");
            }


            return View();
        }

        public IActionResult BookList()
        {
            return View();
        }
        

    }
}
