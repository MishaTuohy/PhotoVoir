using PhotoVoir.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoVoir.Domain.Entities.Users
{
    public class Photographer : User
    {
        public List<Product> Products { get; set; }
    }
}
