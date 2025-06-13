using BooksApi.Entity.Context;
using BooksApi.Entity.Entities;
using BooksApi.Entity.Repositories.Interface;



namespace BooksApi.Entity.Repositories
{
    public class BookRepository(BooksDbContext bookDbContext) : IBookRepository
    {
        private readonly BooksDbContext _dbContext = bookDbContext;
    
        public async Task InsertBook(BookDetails bookDetails)
        {
            await _dbContext.BookDetails.AddAsync(bookDetails);
            await _dbContext.SaveChangesAsync();
        }
        public BookDetails GetById(int id)
        {
            System.Linq.Expressions.Expression<Func<BookDetails, bool>> predicate = x => x.Id == id;
            return _dbContext.BookDetails.FirstOrDefault(x => x.Id == id)!;
        }

        public BookDetails GetBookDetails(int id)
        {
            throw new NotImplementedException();
        }
    }

}
