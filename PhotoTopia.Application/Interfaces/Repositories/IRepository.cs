using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PhotoVoir.Application.Interfaces.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<bool> AddAsync(T entity);
        Task<bool> UpdateAllAsync(T entity);
        Task<bool> DeleteAsync(Guid Id);
        Task<T> GetByIdAsync(Guid Id);
        Task<IReadOnlyList<T>> GetAllAsync();
    }
}
