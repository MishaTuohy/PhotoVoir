using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Photovoir.Interfaces
{
    public interface IOrderDao
    {
        string InsertSql();
        string DeleteSql();
        string GetAllSql();
        string GetByIdSql();
        string UpdateSql();
    }
}
