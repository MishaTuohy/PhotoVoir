using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityManagement.Entities
{
    public class RoleInfo : IRole
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
