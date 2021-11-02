using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoVoir.Domain.Entities.Payment.Method
{
    public class CustomerPaymentMethod
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public string PaymentMethodCode { get; set; }
        public string CreditCardNumber { get; set; }
        public string PaymentMethodDetails { get; set; }
    }
}
