using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace WebApp
{
    public class Frase
    {
        [Required]
        public string frase { get; set; }
    }
}
