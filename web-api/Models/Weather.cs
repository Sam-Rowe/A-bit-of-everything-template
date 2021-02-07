using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace web_api.Models
{
    public class Weather
    {
        [Key]
        public int Location { get; set; }
        public decimal TemperatureC { get; set; }
        public string Summary { get; set; }
        public DateTime Date { get; set; }
    }
}