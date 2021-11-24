using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PhotoVoir.Domain.Entities.Products
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public Guid AuthorId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string ProductSize { get; set; }
        public string ProductDescription { get; set; }
    }
}
