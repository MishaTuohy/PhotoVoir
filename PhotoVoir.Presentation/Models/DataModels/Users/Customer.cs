using PhotoVoir.Presentation.Models.DataModels.Users.Details;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoVoir.Presentation.Models.DataModels.Users
{
    public class Customer : User
    {
        public OrderHistory OrderHistory { get; set; }
        public ShippingAddress ShippingAddress { get; set; }
    }
}
