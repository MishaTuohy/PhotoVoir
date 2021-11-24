using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PhotoVoir.Domain.Entities.Users
{
    public class ShippingAddress
    {
        [Key]
        public Guid Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Town_City { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
    }
}
