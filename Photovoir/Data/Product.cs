using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Photovoir.Data
{
    public class Product
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Tags { get; set; }
        public string Description { get; set; }
    }
}