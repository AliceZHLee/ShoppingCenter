using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCenter.Dtos
{
    public class CartDto
    {
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int Qty { get; set; }
        public string PromoCode { get; set; }
        public string note { get; set; }
    }
}