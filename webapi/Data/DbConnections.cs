// ===========================================================================
/// <summary>
/// DbConnections.cs
/// reactasp-shoper
/// created by Mehrdad Soleimanimajd on 01.08.2023
/// </summary>
/// <created>ʆϒʅ, 01.08.2023</created>
/// <changed>ʆϒʅ, 14.08.2023</changed>
// ===========================================================================

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using webapi_shoper.Models;
using NuGet.Protocol;
using System.Data.Common;

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

        public int[] ProductTable()
        {

            connection.Open();

            // create a table
            var command = connection.CreateCommand();
            command.CommandText = @"select * from Products";

            //command.CommandText = @"Drop Table Products;Drop Table Products2;Alter Table Products3 Drop column test;";
            //command.CommandText = @"Alter Table Products3 Change c2 test INT;";
            var result = command.ExecuteReaderAsync();
            SqliteDataReader reader = null;
            var aaa = result.Result.GetEnumerator();

            //var r = result.Result.;


            var numberOfColumns = result.Result.VisibleFieldCount;

            int[] ids = new int[numberOfColumns];
            string[] names = new string[numberOfColumns];
            string[] models = new string[numberOfColumns];
            string[] descriptions = new string[numberOfColumns];
            string[] categories = new string[numberOfColumns];
            var index = 0;

            //List<Product> columns = null;
            //Product temp = null;

            while (result.Result.Read())
            {
                for (int i = 0; i < numberOfColumns; i++)
                {
                    switch (i)
                    {
                        case 0:
                            ids[index] = result.Result.GetInt32(i);
                            break;
                        case 1:
                            names[index] = result.Result.GetString(i);
                            break;
                        case 2:
                            names[index] = result.Result.GetString(i);
                            break;
                        case 3:
                            names[index] = result.Result.GetString(i);
                            break;
                        case 4:
                            names[index] = result.Result.GetString(i);
                            break;
                    }

                }
                index++;
            }

            connection.Close();
            return ids;
        }

    }
}
