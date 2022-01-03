using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhackTech.Models
{
    public class ApplicationUser : IdentityUser
    {
        //public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string PLZ { get; set; }
        public string City { get; set; }
        public string Canton { get; set; }
        public string Phone { get; set; }
        public int? ShoppingCartId { get; set; }

        public ShoppingCart ShoppingCart { get; set; }
        public List<Order> Orders { get; set; }
    }
}
