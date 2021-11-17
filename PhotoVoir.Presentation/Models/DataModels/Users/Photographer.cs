using PhotoVoir.Presentation.Models.DataModels.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoVoir.Presentation.Models.DataModels.Users
{
    public class Photographer : User
    {
        public List<Product> Products { get; set; }
    }
}
