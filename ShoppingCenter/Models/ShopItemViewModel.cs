﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCenter.Models
{
    public class ShopItemViewModel
    {
        public List<Product> Products { get; set; }
        
    }
}