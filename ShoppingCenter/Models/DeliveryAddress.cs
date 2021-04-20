using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingCenter.Models
{
    public class DeliveryAddress
    {
        public int DeliveryAddressId { get; set; }        
        public string Details { get; set; }
        public bool IsDefaultAddress { get; set; }
        public string ContactPersonName{get;set;}

        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public Customer Customer { get; set; }//FK
        public int CustomerId { get; set; }
    }
}