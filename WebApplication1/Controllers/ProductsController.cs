using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context = null;

        public ProductsController()
        {
            _context= new ApplicationDbContext();
        }

        // GET: Products/Index
        public ActionResult Index()
        {
           /* Product product= new Product();
            var products =  product.GetProducts();
            return View(products);*/

            var products = _context.Products.ToList();
            return View(products);
        }

        // GET: Products/Details/{Id}
        public ActionResult Details(int id)
        {
            /* Product productObj = new Product();
             var product = productObj.GetProducts().FirstOrDefault(p =>p.Id == id);
 */

            //var product = _context.Products.Include(p => p.Category).FirstOrDefault(p => p.Id == id);
            var product = _context.Products.Include(p => p.Category).FirstOrDefault(p => p.Id == id);
            if(product != null)
            {
                return View(product);
            }

            return Content($"No Product available with {id}");
        }


        //create a new product
       public ActionResult Create()
        {
            var categories = _context.Categories.ToList();
          
            ViewBag.Categories = categories;
            return View();
        }


        [HttpPost]
        public ActionResult Create(Product product)
        {
            if(ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            var categories = _context.Categories.ToList();
            ViewBag.Categories = categories;
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if(product != null)
            {
                var categories = _context.Categories.ToList();

                ViewBag.Categories = categories;
                return View(product);
            }
            return HttpNotFound("Product Id Doesn't Exists");
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (product != null)
            {
                var productInDb = _context.Products.Find(product.Id);
                if(productInDb != null )
                {
                    productInDb.Price = product.Price;
                    productInDb.Quantity = product.Quantity;
                    // _context.Products.AddOrUpdate(productInDb);
                    _context.SaveChanges();
                }
               return RedirectToAction("Index");
            }

            var categories = _context.Categories.ToList();
            ViewBag.Categories = categories;
            return View(product);
        }


        [HttpPost]
        public ActionResult Delete(int id)
        {
            var product = _context.Products.FirstOrDefault(p =>p.Id == id);
            if(product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();
        }
        //Products/MyOrders/101
        public ActionResult MyOrders(int id)
        {
            MyOrderDetailsViewModel vm = new MyOrderDetailsViewModel();
            vm.Name = new Customer().GetCustomers().FirstOrDefault(c => c.Id == id)?.Name;

            vm.Products = new Product().GetProducts();
            if (vm.Name != null)
            {
                return View(vm);
            }

            return HttpNotFound("No Customer with id :" + id +"  Please provide a valid Id");
        }
    }
}