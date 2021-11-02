using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoVoir.Domain.Entities.Orders
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public string OrderStatusCode { get; set; }
        public OrderItem OrderItems {get; set;}
        public DateTime DateOrderPlaced { get; set; }
        public string OrderDetails { get; set; }
    }
}
