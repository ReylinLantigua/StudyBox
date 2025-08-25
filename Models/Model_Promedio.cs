using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Model_Promedio
    {
        [Required]
        public int num1 { get; set; }
        [Required]
        public int num2 { get; set; }
        [Required]
        public int num3 { get; set; }
        public int mayor { get; set; }
        public int menor { get; set; }
        public float promedio { get; set; }
    }
}
