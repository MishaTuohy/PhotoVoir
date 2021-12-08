using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Photovoir.Interfaces
{
    public interface IProductDao
    {
        string InsertSql();
        string DeleteSql();
        string GetAllSql();
        string GetByIdSql();
        string UpdateSql();
        string UpdateNameSql();
        string UpdatePriceSql();
        string UpdateTagsSql();
        string UpdateDescriptionSql();
    }
}
