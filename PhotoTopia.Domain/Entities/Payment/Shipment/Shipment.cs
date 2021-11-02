using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoVoir.Domain.Entities.Payment.Shipment
{
    public class Shipment
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid InvoiceId { get; set; }
        public DateTime ShipmentDate { get; set; }
        public ShipmentItem ShipmentItems { get; set; }
    }
}
