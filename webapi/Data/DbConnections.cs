// ===========================================================================
/// <summary>
/// DbConnections.cs
/// reactasp-shoper
/// created by Mehrdad Soleimanimajd on 01.08.2023
/// </summary>
/// <created>ʆϒʅ, 01.08.2023</created>
/// <changed>ʆϒʅ, 09.08.2023</changed>
// ===========================================================================

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using webapi_shoper.Models;

namespace webapi_shoper.Data
{
    public class DbConnections
    {
        //DbConnections
        SqliteConnection connection;

        public DbConnections(string? connectionSting)
        {
            connection = new SqliteConnection(connectionSting);
            connection.Open();

            // create a table
            var command = connection.CreateCommand();
            command.CommandText = @"CREATE TABLE IF NOT EXISTS Products ( Id INT PRIMARY KEY, Name VARCHAR(100), Model VARCHAR(100), Description VARCHAR(1000), Category VARCHAR(100) )";

            //command.CommandText = @"Drop Table Products;Drop Table Products2;Alter Table Products3 Drop column test;";
            //command.CommandText = @"Alter Table Products3 Change c2 test INT;";
            var result = command.ExecuteNonQueryAsync();

            connection.Close();
        }

        //public DbSet<Cart> Carts { get; set; }
        //public DbSet<Product> Products { get; set; }
        //public DbSet<Purchase> Purchases { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Cart>().ToTable("Carts");
        //    modelBuilder.Entity<Product>().ToTable("Products");
        //    modelBuilder.Entity<Purchase>().ToTable("Purchases");
        //}

    }
}
