using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null;
        public decimal Price { get; set; }
    }
}