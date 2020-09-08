using Microsoft.EntityFrameworkCore;
using BookAuthors.Models;

namespace BookAuthors.DAO
{
    public class AuthorDbContext : DbContext
    {
        public AuthorDbContext(DbContextOptions<AuthorDbContext> options) : base(options)
        {

        }
        DbSet<BookAuthorModel> authors {get;set;}
    }
}