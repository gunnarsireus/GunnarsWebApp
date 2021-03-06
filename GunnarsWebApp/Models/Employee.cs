﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GunnarsWebApp.Models
{
    [Table("Employees")]
    public class Employee
    {
        public Employee()
        {
            Addresses = new List<Address>();
            Contacts = new List<Contact>();
        }
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department department { get; set; }

        [Required]
        [Display(Name = "Förnamn")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Efternamn")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Användarnamn")]
        [Remote("IsUserNameAvailable", "Employee", ErrorMessage = "Användarnamn används redan")]
        public string UserName { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}