using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoVoir.Domain.Entities.Payment.Invoice
{
    public class Invoice
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public string InvoiceStatusCode { get; set; }
        public DateTime Date { get; set; }
        public string Details { get; set; }
    }
}
