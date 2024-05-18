﻿using BookLib.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookLib.Data.Repository.Implementations
{
    public class Repository : IRepository
    {
        private readonly BookLibDbContext _ctx;
        public Repository(BookLibDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<int> AddAsync<T>(T entity) where T : class
        {
            await _ctx.Set<T>().AddAsync(entity);
            return await _ctx.SaveChangesAsync();
        }


        public async Task<int> DeleteAsync<T>(T entity) where T : class
        {
            _ctx.Set<T>().Remove(entity);
            return await _ctx.SaveChangesAsync();
        }

        public async Task<IQueryable<T>> GetAsync<T>() where T : class
        {
            return _ctx.Set<T>().AsQueryable();
        }
        public async Task<T?> GetAsync<T>(string id) where T : class
        {
            return await _ctx.Set<T>().FindAsync(id);
        }
        public async Task<int> UpdateAsync<T>(T entity) where T : class
        {
            _ctx.Set<T>().Update(entity);
            return await _ctx.SaveChangesAsync();
        }
    }
}
