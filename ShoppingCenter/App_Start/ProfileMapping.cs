using AutoMapper;
using ShoppingCenter.Dtos;
using ShoppingCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCenter.App_Start
{
    public class ProfileMapping:Profile
    {
        public ProfileMapping()
        {
            Mapper.CreateMap<Product, ProductDto>();
            Mapper.CreateMap<ProductDto, Product>().ForMember(m => m.ProductId, opt => opt.Ignore());

            Mapper.CreateMap<Cart, CartDto>();
            Mapper.CreateMap<CartDto, Cart>();


        }
    }
}