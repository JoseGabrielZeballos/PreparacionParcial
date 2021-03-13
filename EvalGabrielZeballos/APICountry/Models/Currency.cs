using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APICountry.Models
{
    public class Currency
    {
        [Key]
        public string code { get; set; }
        [Required]
        public string name { get; set; } 
        [Required]
        [StringLength(5,MinimumLength =1,ErrorMessage ="Ingrese entre 1 a 5 caracteres" )]
        public string symbol { get; set; }
    }
}