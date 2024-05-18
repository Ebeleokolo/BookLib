using BookLib.Models.Entities;

namespace BookLib.Services.Interface
{
    public interface IBookService
    {
        Task AddBook(Book entity);
        Task UpdateBook(Book entity);
        Task DeleteBook(Book entity);
        Task <Book?> GetBook(string id);
        Task<IEnumerable<Book>> GetBooks();
 
    }
}
