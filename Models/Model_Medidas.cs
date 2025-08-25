using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Model_Medidas
    {
        [Required]
        public int lado_1 { get; set; }
        [Required]
        public int lado_2 { get; set; }
        [Required]
        public int lado_3 { get; set; }
    }
}
