using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class MyOrderDetailsViewModel
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}