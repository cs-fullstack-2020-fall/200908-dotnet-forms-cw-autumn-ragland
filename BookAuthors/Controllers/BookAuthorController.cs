using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using BookAuthors.DAO;
using BookAuthors.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

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
            if(found != null)
            {
                return View(found);
            } else 
            {
                ViewData["error"] = "No matching author found";
                return View("Error");         
            }
        }
        public IActionResult ListBookAuthors()
        {
            return View(_context);
        }
        public IActionResult BookAuthorForm(BookAuthorModel newAuth)
        {
            return View("NewBookAuthor");
        }
        [HttpPost]
        public IActionResult AddBookAuthor(BookAuthorModel newAuth)
        {
            if(ModelState.IsValid)
            {
            _context.authors.Add(newAuth);
            _context.SaveChanges();
            return RedirectToAction("ListBookAuthors","BookAuthor");
            } else 
            {
                List<string> errors = GetErrorListFromModelState(ModelState);
                string displayErr = "";
                errors.ForEach(err => displayErr += err);
                ViewData["errors"] = displayErr;
                return View("NewBookAuthor", newAuth);
            }

        }
        // method to capture model state validation errors
        public static List<string> GetErrorListFromModelState(ModelStateDictionary modelState)
        {
            IEnumerable<string> query = from state in modelState.Values
                from error in state.Errors
                select error.ErrorMessage;

            List<string> errorList = query.ToList();
            return errorList;
        }
    }   
}