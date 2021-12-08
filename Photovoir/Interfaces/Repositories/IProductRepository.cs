using Photovoir.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Photovoir.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<bool> UpdateName(int Id, string Name);
        Task<bool> UpdatePrice(int Id, string Price);
        Task<bool> UpdateTags(int Id, string Tags);
        Task<bool> UpdateDescription(int Id, string Description);
    }
}
