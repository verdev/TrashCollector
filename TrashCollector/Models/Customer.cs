using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle Initial")]
        public char? MiddleInitial { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public int Zip { get; set; }
        [Required]
        public string Phone { get; set; }
        [Display(Name = "Special Pickup Request Date")]
        public DateTime?  SpecialPUDate { get; set; }
        [Display(Name = "Suspend Services Start Date")]
        public DateTime? SuspendStartDate { get; set; }
        [Display(Name = "Suspend Services End Date")]
        public DateTime? SuspendEndDate { get; set; }










    }
}