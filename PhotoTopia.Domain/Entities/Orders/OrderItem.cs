using PhotoVoir.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PhotoVoir.Domain.Entities.Orders
{
    public class OrderItem
    {
        [Key]
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public List<ProductInfo> Products { get; set; }
        public int OrderItemQuantity { get; set; }
        public double OrderItemPrice { get; set; }
    }
}
