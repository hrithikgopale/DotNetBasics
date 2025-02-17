using BookManagementService.Data;
using BookManagementService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookManagementService.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext db;
        public BooksController(ApplicationDbContext db) { 
        
            this.db = db;
        }
        public IActionResult Index()
        {
            var d = HttpContext.Session.GetString("user");
            if (d == null)
            {
                return RedirectToAction("Login","Account");
            }
            else
            {
                ViewBag.Us = d.ToString();
                var books = db.books.ToList();
                return View(books);
            }
           
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            Book b = new Book()
            {
                Id = book.Id,
                Title= book.Title,
                author=book.author,
                price=book.price
            };
            db.books.Add(b);
            db.SaveChanges();
            return RedirectToAction("Index");
            
        }

        public IActionResult Edit(int id)
        {
            var book = db.books.Find(id);
            if (book == null)
            {
                return NotFound();
            }
            else
            {
                return View(book);
            }
            
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                db.books.Update(book);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(book);
        }

        public IActionResult Delete(int id)
        {
            var book = db.books.Find(id);
            if (book == null) return NotFound();

            db.books.Remove(book);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
