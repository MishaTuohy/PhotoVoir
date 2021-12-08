using Photovoir.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Photovoir.Data.DataAccessObjects
{
    public class ProductDao : IProductDao
    {
        public string InsertSql()
        {
            return @"INSERT INTO [dbo].[Product] ([Id], [AuthorId], [Name], [Price],
                    [Tags], [Description])
                    VALUES (@Id, @AuthorId, @Name, @Price, @Tags, @Description);
                    SELECT SCOPE_IDENTITY()";
        }
        public string DeleteSql()
        {
            return @"DELETE FROM [dbo].[Product] 
                   WHERE Id = @Id";
        }

        public string GetAllSql()
        {
            return @"Select * From [dbo].[Product]";
        }

        public string GetByIdSql()
        {
            return @"SELECT * FROM [dbo].[Product]
                   WHERE [Id] = @Id";
        }

        public string UpdateSql()
        {
            return @"UPDATE [dbo].[Product] SET
                    [Name] = @Name,
                    [Price] = @Price,
                    [Tags] = @Tags,
                    [Description] = @Description,
                    WHERE [Id] = @Id";
        }

        public string UpdateNameSql()
        {
            return @"UPDATE [dbo].[Product] 
                    SET Name = @Name
                    WHERE Id = @Id";
        }

        public string UpdatePriceSql()
        {
            return @"UPDATE [dbo].[Product] 
                    SET Price= @Price
                    WHERE Id = @Id";
        }

        public string UpdateTagsSql()
        {
            return @"UPDATE [dbo].[Product] 
                    SET Tags = @Tags
                    WHERE Id = @Id";
        }

        public string UpdateDescriptionSql()
        {
            return @"UPDATE [dbo].[Product] 
                    SET Description = @Description
                    WHERE Id = @Id";
        }
    }
}
