using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCenter.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public int Qty { get; set; }
        public double Unit_price { get; set; }
        public double Total_price { get; set; }
       
        public string PromoCode { get; set; }
        public string Note { get; set; }
        public string DeliveryAddress { get; set; }
        public DateTime OrderDate { get; set; }
        public int DeliveryStatus { get; set; }//0--NOT ARRIVED, 1--RECEIEVED

        public Customer Customer { get; set; }//FK
        public int CustomerId { get; set; }
    }
}