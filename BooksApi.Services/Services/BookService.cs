using BooksApi.Entity.Entities;
using BooksApi.Models;
using BooksApi.Entity.Repositories.Interface;
using BooksApi.Services.Services.NewFolder;


namespace BooksApi.Services
{
    // For CRUD on books
    public class IBookService  : Services.NewFolder.IBookService
    {
        private List<Book> _books;
        private readonly IBookRepository _bookRepository;

        public IBookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
            _books = new List<Book>();
           
        }

        // To Add Book
        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        // To Get All Books
        public List<Book> GetAll()
        {
            return _books;
        }

        // To Get Single Book
        public Book? GetBookById(int id)
        {
            return _books.Find(x => x.Id == id);
        }

        public async Task InsertBook(BookDetails bookDetails)
        {
            await _bookRepository.InsertBook(bookDetails);
        }

        public BookDetails GetBookDetailsById(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        // To Update Book
        // To Delete Book
    }
}
