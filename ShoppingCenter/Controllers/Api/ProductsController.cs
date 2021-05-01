using ShoppingCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using ShoppingCenter.Dtos;

namespace ShoppingCenter.Controllers.Api
{
    public class ProductsController : ApiController
    {
        private ApplicationDbContext _context;
        public ProductsController()
        {
            _context = new ApplicationDbContext();
        }

        //GET: /api/products
        public IHttpActionResult GetProducts()
        {
            return Ok(_context.Products.ToList().Select(Mapper.Map<Product,ProductDto>));
        }

        //GET: /api/products/1
        public IHttpActionResult GetProducts(int id)
        {
            var product = _context.Products.SingleOrDefault(c => c.ProductId == id);
            if (product == null)
                return NotFound();
            return Ok(Mapper.Map<Product,ProductDto>(product));
        }

        //POST: /api/products
        [HttpPost]
        public IHttpActionResult CreateProduct(ProductDto productDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var product = Mapper.Map<ProductDto, Product>(productDto);
            _context.Products.Add(product);
            _context.SaveChanges();
            productDto.ProductId = product.ProductId;

            return Created(new Uri(Request.RequestUri+"/"+product.ProductId),productDto);
        }

        //PUT: /api/products/1
        [HttpPut]
        public IHttpActionResult UpdateProduct(int id,ProductDto productDto)
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

        //DELETE: /api/products/1
        [HttpDelete]
        public IHttpActionResult DeleteProduct(int id)
        {
            var product = _context.Products.SingleOrDefault(c => c.ProductId == id);
            if (product == null)
                return NotFound();

            _context.Products.Remove(product);
            _context.SaveChanges();

            return Ok();
        }
    }
}
