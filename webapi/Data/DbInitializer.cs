// ===========================================================================
/// <summary>
/// DbInitializer.cs
/// reactasp-shoper
/// created by Mehrdad Soleimanimajd on 01.08.2023
/// </summary>
/// <created>ʆϒʅ, 01.08.2023</created>
/// <changed>ʆϒʅ, 06.08.2023</changed>
// ===========================================================================

using webapi_shoper.Data;
using webapi_shoper.Models;

namespace webapi_shoper.Data
{
    public class DbInitializer
    {
        // initialize dummy data
        public static void Initialize(shoperSQLEContext context)
        {
            if (context.Products.Any())
            {
                //
            } else
            {

                var products = new Product[]
                        {
                                new Product{Name="p1", Model="m1"},
                                new Product{Name="p2", Model="m1"},
                                new Product{Name="p3", Model="m2", Category="aaa"},
                                new Product{Name="p4", Model="m2"},

                        };
                context.AddRange(products);
                context.SaveChanges();
            }

            if (context.Carts.Any())
            {
                //
            } else
            {


                var carts = new Cart[]
                {
                new Cart{ Id=100, Type="T1", Size=Cart.CartSize.small},
                new Cart{ Id=101, Type="T1", Size=Cart.CartSize.medium},
                new Cart{ Id=102, Type="T1", Size=Cart.CartSize.big},
                new Cart{ Id=103, Type="T1"},
                };

                context.AddRange(carts);
                context.SaveChanges();
            }

            if (context.Purchases.Any())
            {
                //
            } else
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
            }

        }
        public static void Initialize(shoperSQLiteContext context)
        {
            //if (context.Products.Any())
            //{
            //    //
            //} else
            {

                var products = new Product[]
                        {
                                new Product{Name="p1", Model="m1"},
                                new Product{Name="p2", Model="m1"},
                                new Product{Name="p3", Model="m2", Category="aaa"},
                                new Product{Name="p4", Model="m2"},

                        };
                context.AddRange(products);
                //context.SaveChanges();
            }
        }

    }
}
