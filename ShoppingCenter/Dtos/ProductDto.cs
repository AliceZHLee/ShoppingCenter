using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCenter.Dtos
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string ProductDescription { get; set; }
        public int Stock { get; set; }
        public string Notice { get; set; }// for example, new, sale, out of stock
    }
}