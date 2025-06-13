using BooksApi.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace BooksApi.Entity.Context
{
    public class BooksDbContext(DbContextOptions<BooksDbContext> options) : DbContext(options)
    {
        public DbSet<BookDetails> BookDetails { get; set; }
    }
}



