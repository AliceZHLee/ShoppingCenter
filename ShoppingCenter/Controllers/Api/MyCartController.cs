using AutoMapper;
using ShoppingCenter.Dtos;
using ShoppingCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShoppingCenter.Controllers.Api
{
    public class MyCartController : ApiController
    {
        private ApplicationDbContext _context;
        public MyCartController()
        {
            _context = new ApplicationDbContext();
        }

        //GET: /api/MyCart
        public IHttpActionResult GetMyCart()
        {
            return Ok();
        }

        //GET: /api/MyCart/1
        public IHttpActionResult GetMyCart(int id)
        {
            var product = _context.Cart.SingleOrDefault(c => c.ProductId == id);
            if (product == null)
                return NotFound();
            return Ok();
        }

        //POST: /api/MyCart
        [HttpPost]
        public IHttpActionResult CreateCartItem(CartDto mycartDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var newCartItem = Mapper.Map<CartDto, Cart>(mycartDto);
            //use Session to retrieve customer id
            //newCartItem.CustomerId = ;

            _context.Cart.Add(newCartItem);
            _context.SaveChanges();
            mycartDto.ProductId = newCartItem.ProductId;

            return Created(new Uri(Request.RequestUri + "/" + newCartItem.ProductId), mycartDto);
        }

        //PUT: /api/MyCart/1
        [HttpPut]
        public IHttpActionResult UpdateCartItem(int id, CartDto productDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var productInDb = _context.Products.SingleOrDefault(c => c.ProductId == id);
            if (productInDb == null)
                return NotFound();

            Mapper.Map(productDto, productInDb);
            _context.SaveChanges();

            return Ok(productDto);
        }

        //DELETE: /api/MyCart/1
        [HttpDelete]
        public IHttpActionResult DeleteCartItem(int id)
        {
            var cartItem = _context.Cart.SingleOrDefault(c => c.ProductId == id);
            if (cartItem == null)
                return NotFound();

            _context.Cart.Remove(cartItem);
            _context.SaveChanges();

            return Ok();
        }
    }
}

