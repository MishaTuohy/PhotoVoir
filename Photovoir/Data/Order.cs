﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Photovoir.Data
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public double TotalCost { get; set; }
        public List<int> ProductIds { get; set; }
    }
}
