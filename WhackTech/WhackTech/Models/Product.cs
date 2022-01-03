using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhackTech.Models
{
    public class Product
    {
        public int ID { get; set; }
        public int Name { get; set; }
        public string Description { get; set; }
        public string imgURL { get; set; }
        public decimal Price { get; set; }
    }
}
