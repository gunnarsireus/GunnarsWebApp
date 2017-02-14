using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GunnarsWebApp.Models
{
    [Table("Addresses")]
    public class Address
    {
        public Address()
        {
            City = "-";
            Street = "-";
            Zip = "-";
        }
        public int Id { get; set; }
        public int EmployeeId { get; set; }

        [Required]
        [Display(Name = "City")]
        public string City { get; set; }


        [Required]
        [Display(Name = "Street")]
        public string Street { get; set; }


        [Required]
        [Display(Name = "Zip")]
        public string Zip { get; set; }

    }
}