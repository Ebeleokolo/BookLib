using BookLib.Data.Repository.Interfaces;
using BookLib.Models.Entities;
using BookLib.Services.Interface;

namespace BookLib.Services.Implementation
{
    public class BookService : IBookService
    {
        private readonly IRepository _repository;
        public BookService(IRepository repository)
        {
            _repository = repository;
        }
        
        public async Task AddBook(Book entity)
        {
          await _repository.AddAsync(entity);
        }

        public async Task DeleteBook(Book entity)
        {
            await _repository.DeleteAsync(entity);
        }

        public async Task <Book?> GetBook(string BookId)
        {
            return await _repository.GetAsync<Book>(BookId);
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _repository.GetAsync<Book>();
        }

        public async Task UpdateBook(Book entity)
        {
            await _repository.UpdateAsync(entity);
        }
    }
}
