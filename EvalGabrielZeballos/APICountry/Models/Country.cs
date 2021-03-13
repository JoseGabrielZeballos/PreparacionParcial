using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APICountry.Models
{
    public class Country
    {
        [Key]
        public string name { get; set; }
        
        [Required]
        public string capital { get; set; }  
        public int population { get; set; }
        public List<double> latlng { get; set; }
        public List<string> timezones { get; set; }
        public List<Currency> currencies { get; set; }
        public string flag { get; set; }
        
    }
}