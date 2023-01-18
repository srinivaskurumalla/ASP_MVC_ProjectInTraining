using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }

        
        public DateTime DateOfBirth { get; set; }

      //  public ICollection<Address> Addresses { get; set; }
      //  public Address Address { get; set; }
      //  public string City { get; set; }

        //Navigation Property
      /*  public Address Address { get; set; }

        //Foreign Key
        public int Address_AddressId { get; set; }
*/
        public List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer{Id = 101,Name = "Srinivas",MobileNo="1234"},
                new Customer{Id = 102,Name = "Chandu",MobileNo="5678"},
                new Customer{Id = 103,Name = "Ajay",MobileNo="8901"},
                new Customer{Id = 104,Name = "Srikanth",MobileNo="0431"},
            };
        }
    }
}