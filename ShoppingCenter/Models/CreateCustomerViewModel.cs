﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCenter.Models
{
    public class CreateCustomerViewModel
    {
        public Customer Customer { get; set; }
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
    }
}