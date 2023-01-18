using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class AddressDD
    {
        [Key]
        public int AddressDDId { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string HouseNo { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string StreetName { get; set; }

       
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string FlatName { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string AddressLine1 { get; set; }

       
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string AddressLine2 { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string PinCode { get; set; }
      

    }
}