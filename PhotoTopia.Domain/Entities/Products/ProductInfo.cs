using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PhotoVoir.Domain.Entities.Products
{
    public class ProductInfo
    {
        [Key]
        public Guid Id { get; set; }
        public Product ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
