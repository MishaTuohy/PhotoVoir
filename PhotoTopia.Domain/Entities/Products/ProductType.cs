using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoVoir.Domain.Entities.Products
{
    public class ProductType
    {
        public string ProductTypeCode { get; set; }
        public string ParentProductTypeCode { get; set; }
        public string ProductTypeDescription { get; set; }
    }
}
