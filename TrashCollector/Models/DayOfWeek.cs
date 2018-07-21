using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class DayOfWeek
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Day of the Week")]
        public string DoW { get; set; }











    }
}