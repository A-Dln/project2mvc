using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PROJECT2MVC.Buddies
{
    public class ProductProperties
    {
        [Required]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Verplicht")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "{0} heeft min. {2} en max. {1} karakters")]
        public string ProductCode { get; set; }
        [Required(ErrorMessage = "Verplicht")]
        [StringLength(50, ErrorMessage = "{0} heeft max. {1} karakters")]
        public string Omschrijving { get; set; }
        public string Eenheid { get; set; }
        [Required(ErrorMessage = "Verplicht")]
        public decimal PrijsPerEenheid { get; set; }
    }
}