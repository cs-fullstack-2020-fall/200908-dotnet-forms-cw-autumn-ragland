using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using BookAuthors.DAO;
using BookAuthors.Models;

namespace BookAuthors.Controllers
{
    public class BookAuthor : Controller
    {
        private readonly AuthorDbContext _context;
        public BookAuthor(AuthorDbContext context)
        {
            _context = context;
        }
        public IActionResult ViewBookAuthor(int authID)
        {
            BookAuthorModel found = _context.authors.FirstOrDefault(auth => auth.id == authID);
            return View(found);
        }
        public IActionResult ListBookAuthors()
        {
            return View(_context);
        }
        public IActionResult BookAuthorForm()
        {
            return View("NewBookAuthor");
        }
        [HttpPost]
        public IActionResult AddBookAuthor(BookAuthorModel newAuth)
        {
            _context.authors.Add(newAuth);
            _context.SaveChanges();
            return RedirectToAction("ListBookAuthors","BookAuthor");
        }
    }   
}