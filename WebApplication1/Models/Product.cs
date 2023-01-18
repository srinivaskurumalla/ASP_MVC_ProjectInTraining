using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="product name is mandatory")]
        [Display(Name = "Product Name")]
        [Column(TypeName ="varchar")]
        [StringLength(50)]
        public string ProductName { get; set; }
        [Required]
        [Range(0.0,100000.0,ErrorMessage ="Price Should be between 0 and 100000")]
        public double Price { get; set; }
        [Required]
        public int Quantity { get; set; }

        //Navigation property
        public Category Category { get; set; }  //It is not a cloumn

        //Foreign Key

        public int CategoryId { get; set; }

        public List<Product> GetProducts() {

            return new List<Product>
            {
                new Product{ Id = 101,ProductName = "Mouse",Price=600,Quantity=25},
                new Product{ Id = 102,ProductName = "Charger",Price=3000,Quantity=50},
                new Product{ Id = 103,ProductName = "EarPhones",Price=1000,Quantity=100},
            };
        }
    }
}