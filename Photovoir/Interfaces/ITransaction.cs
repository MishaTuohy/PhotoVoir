using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Photovoir.Interfaces
{
    public interface ITransaction
    {
        // Commits Transaction
        void Commit();
        // Disposes of resources
        void Dispose();
        // Gets DbConnection
        DbConnection GetConnection();
        // Gets DbTransaction
        DbTransaction GetTransaction();
        // Checks for a transaction
        bool HasTransaction();
        // Rolls back transaction, returns to orginal state
        void Rollback();
    }
}
