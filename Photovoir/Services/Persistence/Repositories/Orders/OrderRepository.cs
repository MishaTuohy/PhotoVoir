using Photovoir.Data;
using Photovoir.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Photovoir.Services.Persistence.Repositories.Orders
{
    public class OrderRepository : IOrderRepository
    {
        public Task<bool> AddAsync(Order entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Order>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAllAsync(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
