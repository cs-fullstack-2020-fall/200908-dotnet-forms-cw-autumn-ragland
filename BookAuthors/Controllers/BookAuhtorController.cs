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
        public IActionResult Index()
        {
            return Content("Sanity");
        }
    }   
}