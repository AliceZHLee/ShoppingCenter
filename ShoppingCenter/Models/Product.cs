using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCenter.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string ProductDescription { get; set; }
        public int Stock { get; set; }
        public string Notice { get; set; }// for example, new, sale, out of stock

        public List<ProductPicture> Pictures { get; set; }
    }
}