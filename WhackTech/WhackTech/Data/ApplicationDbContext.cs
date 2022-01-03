using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhackTech.Models;

namespace WhackTech.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {

        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>()
                .HasOne(a => a.ShoppingCart)
                .WithOne(b => b.ApplicationUser)
                .HasForeignKey<ShoppingCart>(b => b.ApplicationUserID);

            builder.Entity<ApplicationUser>()
                .Property(e => e.FirstName);

            builder.Entity<ApplicationUser>()
                .Property(e => e.LastName);

            builder.Entity<ApplicationUser>()
                .Property(e => e.Country);

            builder.Entity<ApplicationUser>()
                .Property(e => e.PLZ);

            builder.Entity<ApplicationUser>()
                 .Property(e => e.City);

            builder.Entity<ApplicationUser>()
                .Property(e => e.Canton);

            builder.Entity<ApplicationUser>()
                .HasMany(e => e.Orders).WithOne(o => o.ApplicationUser);

            builder.Entity<Order>()
                .HasKey(e => e.ID);


        }

    }
}
