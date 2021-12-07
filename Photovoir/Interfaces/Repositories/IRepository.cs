using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Photovoir.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<bool> AddAsync(T entity);
        Task<bool> UpdateAllAsync(T entity);
        Task<bool> DeleteAsync(int Id);
        Task<T> GetByIdAsync(int Id);
        Task<IReadOnlyList<T>> GetAllAsync();
    }
}
