using BookLib.Models.Entities;

namespace BookLib.Data.Repository.Interfaces 
{
    public interface IRepository
    {
        Task<int> Add<T>(T entity);
        Task<int> Update<T>(T entity);
        Task<int> Delete<T>(T entity);
        Task<IQueryable<T>> Get<T>();
        Task<T> Get<T>(string Id);
    }
}
