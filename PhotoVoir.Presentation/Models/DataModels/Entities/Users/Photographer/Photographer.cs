using PhotoVoir.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PhotoVoir.Domain.Entities.Users.Photographer
{
    public class Photographer
    {
        [Key] 
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public ShippingAddress ShippingAddress { get; set; }
        public List<Product> Products { get; set; }
    }
}
