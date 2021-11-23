using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoVoir.Domain.Entities.Users.Auth
{
    public class ApplicationRole
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string NormalizedName { get; set; }
    }
}
