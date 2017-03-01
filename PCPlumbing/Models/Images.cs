using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PCPlumbing.Models
{
    public class Images
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Photo")]
        public string Image { get; set; }
        [Display(Name = "Title")]
        public string ImageName { get; set; }
        [Display(Name = "Description")]
        public string ImageDescription { get; set; }
    }
}