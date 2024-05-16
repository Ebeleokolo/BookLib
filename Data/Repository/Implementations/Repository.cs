using BookLib.Data.Repository.Interfaces;

namespace BookLib.Data.Repository.Implementations
{
    public class Repository : IRepository
    {
        private readonly BookLibDbContext _ctx;
        public Repository(BookLibDbContext ctx)
        {
            _ctx = ctx;
        }

        public Task<int> Add<T>(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete<T>(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<T>> Get<T>()
        {
            throw new NotImplementedException();
        }

        public Task<T> Get<T>(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update<T>(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
