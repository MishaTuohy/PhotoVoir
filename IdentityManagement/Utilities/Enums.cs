using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityManagement.Utilities
{
    public enum EnumUserStatus
    {
        Pending = 0,
        Active,
        LockedOut,
        Closed,
        Banned
    }
}
