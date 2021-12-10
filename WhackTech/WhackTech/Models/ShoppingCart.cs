using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhackTech.Models
{
    public class ShoppingCart
    {
        public int ID { get; set; }
        public int ApplicationUserID { get; set; }
        public decimal CurrentPrice { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
