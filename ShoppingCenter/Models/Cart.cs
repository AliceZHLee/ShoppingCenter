using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShoppingCenter.Models
{
    public class Cart
    {
        [Key]
        [Column(Order = 1)]
        public int ProductId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int CustomerId { get; set; }
        public int Qty { get; set; }
        public string PromoCode { get; set; }
        public string note { get; set; }

        public Customer Customer { get; set; }//navigate to Customers table

        public Product Product { get; set; }//navigate to Products table


    }
}