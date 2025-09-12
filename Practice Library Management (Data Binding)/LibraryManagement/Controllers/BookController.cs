using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace LibraryManagement.Controllers
{
    public class BookController : Controller
    {
        private static List<BookViewModel> _books;

        public BookController() 
        { 
            if (_books == null)
            {
                _books = new List<BookViewModel>();
                getAllBook();
            }
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Books()
        {
            return View(_books);
        }

        public IActionResult Edit (int bookId)
        {
            BookViewModel selectedBook = _books.FirstOrDefault(b => b.Id == bookId);
            return View(selectedBook);
        }


        
        public IActionResult Delete(int bookId)
        {   
            BookViewModel selectedBook = _books.FirstOrDefault(b =>b.Id == bookId);
            _books.Remove(selectedBook);

            return RedirectToAction("Books");

        }


        [HttpPost]
        public IActionResult Update (BookViewModel updateBook)
        {
            BookViewModel book = _books.FirstOrDefault(b => b.Id == updateBook.Id);
            book.Title = updateBook.Title;
            book.Author = updateBook.Author;
            book.Quantity = updateBook.Quantity;
            book.Genre = updateBook.Genre;
            return RedirectToAction("Books");
        }

        private void getAllBook ()
        {
            BookViewModel book1 = new BookViewModel()
            {
                Id = 1,
                Title = "Journey By Boat",
                Author = "Alan Donald",
                Genre = "Motivation",
                Quantity = 420

            };

            BookViewModel book2 = new BookViewModel()
            {
                Id = 2,
                Title = "Journey By Train",
                Author = "Donald Trump",
                Genre = "Motivation",
                Quantity = 530
            };

            _books.Add(book1);
            _books.Add(book2);
        }
    }
}
