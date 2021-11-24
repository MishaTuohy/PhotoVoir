using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PhotoVoir.Domain.Entities.Orders
{
    public class OrderStatus
    {
        [Key]
        public Guid Id { get; set; }
        public string OrderStatusCode { get; set; }
        public string OrderStatusDescription { get; set; }
    }
}
