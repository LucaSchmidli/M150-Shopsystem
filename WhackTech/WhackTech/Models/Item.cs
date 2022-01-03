﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhackTech.Models
{
    public class Item
    {
        public int ID { get; set; }
       // public int ShoppingCartID { get; set; }
        //public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public ShoppingCart ShoppingCart { get; set; }
        public Product Product { get; set; }
    }
}
