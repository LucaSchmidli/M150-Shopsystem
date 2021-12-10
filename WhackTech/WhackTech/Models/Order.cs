using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhackTech.Models
{
    public class Order
    {
        public int ID;
        public int ApplicationUserID;
        public int PaymentMethodID;
        public int TotalPrice;

        public ApplicationUser ApplicationUser;
        public ICollection<Item> Items;
        public PaymentMethod PaymentMethod;
    }
}
