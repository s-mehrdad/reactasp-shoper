// ===========================================================================
/// <summary>
/// shoperContext.cs
/// reactasp-shoper
/// created by Mehrdad Soleimanimajd on 01.08.2023
/// </summary>
/// <created>ʆϒʅ, 01.08.2023</created>
/// <changed>ʆϒʅ, 06.08.2023</changed>
// ===========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlTypes;
using webapi_shoper.Models;

namespace webapi_shoper.Data
{
    public class shoperSQLEContext: DbContext
    {
        public shoperSQLEContext(DbContextOptions<shoperSQLEContext> options)
            : base(options)
        {
        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cart>().ToTable("Carts");
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Purchase>().ToTable("Purchases");
        }
    }

    public class shoperSQLiteContext: DbContext
    {
        public shoperSQLiteContext(DbContextOptions<shoperSQLiteContext> options)
            : base(options)
        {
        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cart>().ToTable("Carts");
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Purchase>().ToTable("Purchases");
        }
    }
}
