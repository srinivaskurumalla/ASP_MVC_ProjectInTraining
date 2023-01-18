using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [RoutePrefix("Customers")]
    public class CustomersController : Controller
    {
        /* // GET: Customers
         public ActionResult Index()
         {
             return Content("Home Page");
         }

         public ActionResult GetCustomer(int? id)
         {
             if (id.HasValue)
             {
                 return Content($"Customer Id : {id.Value}");

             }
             else
             {
                 return null;
             }
         }

         [Route("GetCustomerByName/{name}")]       
         public ActionResult GetCustomerByName(string name)
         {
             if (!string.IsNullOrWhiteSpace(name))
             {
                 return Content($"Customer Name : {name}");

             }
             else
             {
                 return Content("Please provide name");
             }
         }

         [Route("GetCustomerCreatedDate/{name}")]
         public ActionResult GetCustomerCreatedDate(string name)
         {
             return Content($"Hello {name},  Today's Date is {DateTime.Now.ToShortDateString()}");
         }

         public ActionResult GetCustomerByIdAndName(int? id,string name)
         {
             if (id.HasValue || !string.IsNullOrEmpty(name))
             {
                 return Content($"Customer Id : {id.Value} \n Customer Name : {name}");

             }
             else
             {
                 return Content("PLease provide Id or Name");
             }
         }*/
        private readonly ApplicationDbContext _context = null;

        public CustomersController()
        {
            _context= new ApplicationDbContext();
        }

        
        public ActionResult Index()
        {
            /* Customer customer= new Customer();
             List<Customer> customers = customer.GetCustomers();*/
            // ViewBag.Customers = customer.GetCustomers();

            /// ViewData["Customers"] = customer.GetCustomers();
            /// 
           
                var customers = _context.Customers.ToList();
          
            return View(customers);
        }

        //Customers/Details/1
        public ActionResult Details(int id)
        {
           // Customer customerObj= new Customer();
          // var customer = customerObj.GetCustomers().FirstOrDefault(c => c.Id == id);

            var customer = _context.Customers.FirstOrDefault(c => c.Id == id);
            if(customer != null)
            {
                return View(customer);
            }
            return HttpNotFound("Customer with "+  id  + "not exists");

        }

        public ActionResult Create(int id)
        {
            return View();
        }
    }
}