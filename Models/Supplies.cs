using System;
using System.ComponentModel.DataAnnotations;

namespace siwp_app.Models
{
    public class Supplies
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Product Name")]

        public string Name { get; set; }
       
        public string Price { get; set; }

        [Display(Name = "Unit of Measure")]
        public string Unit { get; set; }
        public string Quantity { get; set; }

        [Display(Name = "Additional Notes")]
        public string AdditionalInfo { get; set; }
    }
}