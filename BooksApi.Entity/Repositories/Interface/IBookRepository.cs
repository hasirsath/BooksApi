using BooksApi.Entity.Entities;


namespace BooksApi.Entity.Repositories.Interface
{
    public interface IBookRepository
    {
        Task InsertBook(BookDetails bookDetails);

        BookDetails GetBookDetails(int id);
        BookDetails GetBookById(int id);
    }
}
