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

        public ActionResult Contact()
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

        public ActionResult ShoppingCart()
        {
            var viewModel = new ShoppingCartViewModel()
            {
                Carts = _context.Cart.Include(c=>c.Customer).Include(c => c.Product).Include(c=>c.Product.Pictures).ToList()
            };
            return View(viewModel);
        }

        public ActionResult LogIn()
        {
            if (Session["User"] != null)
            {
                RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogIn(Customer customer)
        {
            //var data=_context.Customers.Any(c=>c.Email==customer.Email && c=>c.Password==customer.Password)
            var email = _context.Customers.Where(c => c.Email == customer.Email).ToList();
            if (email.Count() == 0)
            {
               // 说明用户还没有注册 
               //return "this account is not registered"
            }
            var existingUser = email.Where(c => c.Password == customer.Password).ToList();
            if (existingUser.Count() == 0)
            {
                //说明用户密码输错了，但是我返回的时候还是要说明 密码或邮箱出现了错误
                //return "email or password wrong"
            }

            return RedirectToAction("Index","Home");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Customer customer)
        {
            if (!_context.Customers.Any(c => c.Email == customer.Email))
            {
                _context.Customers.Add(customer);
                _context.SaveChanges();
               
                return RedirectToAction("Index", "Home");
            }
          
            return View("Register");
           
        }

      
      
        public ActionResult LogOut()
        {
            return View();
        }

        public string EncryptPassword(string password)
        {
            var hashcode = password.GetHashCode();
            return hashcode.ToString();
        }




     
        
    }
}