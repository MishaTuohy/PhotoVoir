using Photovoir.Data;
using Photovoir.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Photovoir.Services.Persistence.Repositories.Products
{
    public class ProductRepository : IProductRepository
    {
        public Task<bool> AddAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAllAsync(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
