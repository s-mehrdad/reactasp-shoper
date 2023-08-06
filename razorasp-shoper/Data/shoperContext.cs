using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using razorasp_shoper.Models;

namespace razorasp_shoper.Data
{
        public class shoperContext : DbContext
        {
                public shoperContext(DbContextOptions<shoperContext> options)
                    : base(options)
                {
                }
                public DbSet<Product> Products { get; set; }
                public DbSet<Purchase> Purchases { get; set; }
                public DbSet<Cart> Carts { get; set; }

                protected override void OnModelCreating(ModelBuilder modelBuilder)
                {
                        modelBuilder.Entity<Product>().ToTable("Product");
                        modelBuilder.Entity<Purchase>().ToTable("Purchase");
                        modelBuilder.Entity<Cart>().ToTable("Cart");
                }

                public DbSet<razorasp_shoper.Models.Product> Product { get; set; } = default!;
        }
}
