// ===========================================================================
/// <summary>
/// shoperContext.cs
/// razorasp-shoper
/// created by Mehrdad Soleimanimajd on 03.08.2023
/// </summary>
/// <created>ʆϒʅ, 03.08.2023</created>
/// <changed>ʆϒʅ, 12.08.2023</changed>
// ===========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using razorasp_shoper.Models;

namespace razorasp_shoper.Data
{
    public class shoperContext: DbContext
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
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Purchase>().ToTable("Purchases");
            modelBuilder.Entity<Cart>().ToTable("Carts");
        }

        public DbSet<razorasp_shoper.Models.Product> Product { get; set; } = default!;


        public static void Initialize(shoperContext context)
        {
            // dummy data!
            if (!context.Products.Any())
            {
                var products = new Product[]
                {
                    new Product {
                        Name= "p1", Model="m1", Category=Categories.Appliance,
                        Image="./resources/TalkativeAndShy.bmp"
                    },
                    new Product {
                        Name= "p2", Model="m1", Category=Categories.Gadgets,
                        Description="description",
                        Image="./resources/TalkativeAndShy.bmp"
                    },
                    new Product {
                        Name= "p3", Model="m2", Category= Categories.Wearables,
                        Description="",
                        Image="./resources/TalkativeAndShy.bmp"
                    },
                    new Product {
                        Name= "p4", Model="m2", Category=Categories.Tech,
                        Image="./resources/TalkativeAndShy.bmp"
                    },
                    new Product {
                        Name= "p5", Model="m3", Category=Categories.Tools,
                        Image="./resources/TalkativeAndShy.bmp"
                    },
                    new Product {
                        Name= "p6", Model="m3", Category=Categories.لوازم,
                        Image="./resources/TalkativeAndShy.bmp"
                    },
                };
                context.AddRangeAsync(products);
                context.SaveChanges();
            }

            if (!context.Carts.Any())
            {
                var carts = new Cart[]
                {
                    new Cart{Id= 101,Type="T1",Size=Cart.CartSize.small},
                    new Cart{Id= 102,Type="T1",Size=Cart.CartSize.medium},
                    new Cart{Id= 103,Type="T2",Size=Cart.CartSize.big},
                    new Cart{Id= 104,Type="T2",Size=Cart.CartSize.small},
                    new Cart{Id= 105,Type="T3",Size=Cart.CartSize.big},
                };
                context.AddRangeAsync(carts);
                context.SaveChanges();

            }

            if (!context.Products.Any())
            {

                var purchases = new Purchase[]
            {
                new Purchase{CartId=100,ProductId=1},
                new Purchase{CartId=100,ProductId=2},
                new Purchase{CartId=102,ProductId=4},
                new Purchase{CartId=101,ProductId=1},
                new Purchase{CartId=103,ProductId=1},
                new Purchase{CartId=102,ProductId=2},
                new Purchase{CartId=100,ProductId=3},
                new Purchase{CartId=101,ProductId=4},
                new Purchase{CartId=102,ProductId=1},
            };

                context.AddRange(purchases);
                context.SaveChanges();
            };

        }

    }
}
