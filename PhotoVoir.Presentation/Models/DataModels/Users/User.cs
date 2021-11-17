using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoVoir.Presentation.Models.DataModels.Users
{
    public class User
    {
        public Guid Id = new Guid();
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
