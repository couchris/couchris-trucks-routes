using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CC_LAB1.Models
{
    public class Route
    {
        [Required(ErrorMessage = "Route number field can't be empty.")]
        public int? route_number { get; set; }
        [Required(ErrorMessage = "Route name field can't be empty.")]
        public string? route_name { get; set; }
        [Required(ErrorMessage = "Route length field can't be empty.")]
        public double? r_length { get; set; }
        [Required(ErrorMessage = "Route pay per km field can't be empty.")]
        public double? r_pay_per_km { get; set; }


    }
}
