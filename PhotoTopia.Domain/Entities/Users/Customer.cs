﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoVoir.Domain.Entities.Users
{
    public class Customer : User
    {
        public OrderHistory OrderHistory { get; set; }
        public ShippingAddress ShippingAddress { get; set; }
    }
}
