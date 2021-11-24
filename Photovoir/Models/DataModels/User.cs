using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Photovoir.Models.DataModels
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Status { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
