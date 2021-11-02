using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoVoir.Domain.Entities.Payment.Shipment
{
    public class ShipmentItem
    {
        public Guid Id { get; set; }
        public Guid OrderItemId { get; set; }
    }
}
