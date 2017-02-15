using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GunnarsWebApp.Models
{
    [Table("Contacts")]
    public class Contact
    {
        public Contact()
        {
            Phone = "-";
            Email = "-";
        }
        public int Id { get; set; }
        public int EmployeeId { get; set; }

        [Required]
        [Display(Name = "Telefon")]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Epost")]
        public string Email { get; set; }
    }
}