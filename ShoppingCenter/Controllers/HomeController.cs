using ShoppingCenter.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCenter.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        public HomeController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult FAQ()// 这里可能不需要controller就直接去View就行
        {
            return View();
        }
        public ActionResult Shop()
        {
            var viewModel = new ShopItemViewModel()
            {
                Products = _context.Products.Include(c => c.Pictures).ToList()
            };       
            
            return View(viewModel);
        }
        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult ShoppingCart()
        {
            return View();
        }
        public ActionResult LogIn()
        {
            return View();
        }
        public ActionResult LogOut()
        {
            return View();
        }




     
        
    }
}