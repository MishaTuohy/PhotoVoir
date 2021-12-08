using Photovoir.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Photovoir.Data.DataAccessObjects
{
    public class OrderDao : IOrderDao
    {
        public string InsertSql()
        {
            return @"INSERT INTO [dbo].[ApplicationUser] ([Id], [UserName], [NormalizedUserName], [Email],
                    [NormalizedEmail], [EmailConfirmed], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled])
                    VALUES (@Id, @UserName, @NormalizedUserName, @Email, @NormalizedEmail, @EmailConfirmed, @PasswordHash, @PhoneNumber, 
                    @PhoneNumberConfirmed, @TwoFactorEnabled);
                    SELECT SCOPE_IDENTITY()";
        }
        public string DeleteSql()
        {
            throw new NotImplementedException();
        }

        public string GetAllSql()
        {
            throw new NotImplementedException();
        }

        public string GetByIdSql()
        {
            throw new NotImplementedException();
        }

        public string UpdateSql()
        {
            throw new NotImplementedException();
        }
    }
}
