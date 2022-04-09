using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class BooksController : Controller
    {
       /* public IActionResult Index()
        {
            return View();
        }*/
        public string Index()
        {
            return "This is the book index.";
        }

        public string Details()
        {
            return "This is the details of a book.";
        }
    }
}
