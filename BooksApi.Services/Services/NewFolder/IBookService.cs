

using BooksApi.Entity.Entities;
using BooksApi.Models;

namespace BooksApi.Services.Services.NewFolder
{
    public interface IBookService
    {
        public void AddBook(Book book);

        List<Book> GetAll();

        Book? GetBookById(int id);

        BookDetails GetBookDetailsById(int id);


    }
}
