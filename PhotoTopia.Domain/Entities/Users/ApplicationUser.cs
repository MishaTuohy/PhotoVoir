using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoVoir.Domain.Entities.Users
{
    public class ApplicationUser
    {
        public Guid Id = new Guid();
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Town_City {get;set; }
        public string County { get; set; }
        public string Country { get; set; }
    }
}
