﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoVoir.Domain.Entities.Products
{
    public class Product
    {
        public Guid Id { get; set; }
        public string ProdcutTypeCode { get; set; }
        public Guid ProductAuthor { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string ProductSize { get; set; }
        public string ProductDescription { get; set; }
        public string OtherProductDetails { get; set; }
    }
}