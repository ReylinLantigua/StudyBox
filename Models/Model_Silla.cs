using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApp.Models
{
    public class Model_Silla
    {
        public string imagen { get; set; }
        public int sillas { get; set; }
        public int madera { get; set; }
        public int metal { get; set; }
        public int remaches { get; set; }
        public bool vmateriales = true;
        public const int constmadera = 3;
        public const int constmetal = 2;
        public const int constremaches = 10;
    }
}
