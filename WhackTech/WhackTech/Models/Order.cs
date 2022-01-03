using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhackTech.Models
{
    public class Order
    {
        public int ID { get; set; }
        public int ApplicationUserID { get; set; }
        public int PaymentMethodID { get; set; }
        public int TotalPrice { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        public List<Item> Items { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
