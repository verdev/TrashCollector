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
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle Initial")]
        public char MiddleInitial { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        [Display(Name = "Alternative Contact")]
        public string AltContact { get; set; }
        [Display(Name = "Premises Contact")]
        public string WastePremContact { get; set; }
        [Display(Name = "Billing Street Address")]
        public string StreetAddress { get; set; }
        [Display(Name = "Billing City")]
        public string City { get; set; }
        [Display(Name = "Billing State")]
        public string State { get; set; }
        [Display(Name = "Billing Zip")]
        public int Zip { get; set; }
        [Display(Name = "Premises Street Address")]
        public string WastePremStreetAddress { get; set; }
        [Display(Name = "Premises City")]
        public string WastePremCity { get; set; }
        [Display(Name = "Premises State")]
        public string WastePremState { get; set; }
        [Display(Name = "Premises Zip")]
        public int WastePremZip { get; set; }
        [Display(Name = "Home Area Code")]
        public int HomeAreaCode { get; set; }
        [Display(Name = "Home Phone")]
        public int HomePhone { get; set; }
        [Display(Name = "Mobile Area Code")]
        public int MobileAreaCode { get; set; }
        [Display(Name = "Mobile Phone")]
        public int MobilePhone { get; set; }
        [Display(Name = "Work Area Code")]
        public int WorkAreaCode { get; set; }
        [Display(Name = "Work Phone")]
        public int WorkPhone { get; set; }
        [Display(Name = "Fax Area Code")]
        public int FaxAreaCode { get; set; }
        [Display(Name = "Fax Phone")]
        public int FaxPhone { get; set; }
        [Display(Name = "Premises Area Code")]
        public int WastePremAreaCode { get; set; }
        [Display(Name = "Premises Phone")]
        public int WastePremPhone { get; set; }
        [Display(Name = "Special PU Request Date")]
        public DateTime SpecialPUDate { get; set; }
        [Display(Name = "Suspend Services Start Date")]
        public DateTime SuspendStartDate { get; set; }
        [Display(Name = "Waste GPS Coordinates - Latitude")]
        public float GPSLatitude { get; set; }
        [Display(Name = "Waste GPS Coordinates - Longitude")]
        public float GPSLongitude { get; set; }
        public string Comments { get; set; }









    }
}