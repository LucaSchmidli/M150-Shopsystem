using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhackTech.Models
{
    public class ShoppingCart
    {
        public int ID { get; set; }
        public string ApplicationUserID { get; set; }
        public decimal CurrentPrice { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        public List<Item> Items { get; set; }
    }
}
