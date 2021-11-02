using PhotoVoir.Domain.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoVoir.Domain.Entities.Orders
{
    public class OrderItem
    {
        public Guid Id { get; set; }
        public List<ProductInfo> Products { get; set; }
        public Guid OrderId { get; set; }
        public int OrderItemQuantity { get; set; }
        public double OrderItemPrice { get; set; }
    }
}
