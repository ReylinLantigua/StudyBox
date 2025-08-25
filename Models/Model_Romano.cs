using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Model_Romano
    {
        [Required]
        public int Numero { get; set; }
        public string Romano { get; set; }
    }
}
