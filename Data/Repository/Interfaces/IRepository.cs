﻿using BookLib.Models.Entities;

namespace BookLib.Data.Repository.Interfaces 
{
    public interface IRepository
    {
        Task<int> AddAsync<T>(T entity) where T : class;
        Task<int> UpdateAsync<T>(T entity) where T : class;
        Task<int> DeleteAsync<T>(T entity) where T : class;
        Task<IQueryable<T>> GetAsync<T>() where T : class;
        Task<T> GetAsync<T>(string Id) where T : class;
    }
}
