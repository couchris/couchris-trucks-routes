using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CC_LAB1.Models
{
    public class Truck
    {
        [Required(ErrorMessage = "Truck number field can't be empty.")]
        public int? truck_num { get; set; }
        [Required(ErrorMessage = "Truck model field can't be empty.")]
        public string? t_model { get; set; }
        [Required(ErrorMessage = "Truck make field can't be empty.")]
        public string? t_make { get; set; }
        
        public int? route_number { get; set; }
    }
}
