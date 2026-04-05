using System;
using System.Collections.Generic;
using System.Text;

namespace C__LINQ
{
    public record Product(int Id, string Name, string Category, double Price, int Stock);
    internal class Product_Inventory
    {

        static void Main()
        {
            List<Product> product = new List<Product>
        {
                new Product(1, "Laptop", "Electronics", 55000, 10),
                new Product(2, "Mouse", "Electronics", 500, 50),
                new Product(3, "Chair", "Furniture", 3000, 20),
                new Product(4, "Pen", "Stationery", 20, 200),
                new Product(5, "Pen", "Stationery", 20, 0)
        };

            /*
            //1. Get products with stock < 10
            var prod = from i in product
                        where i.Stock > 10
                        select i;
            foreach (var item in prod)
            {
                Console.WriteLine(item);
            }

            }
            
            //2. Get top 3 expensive products

            var top_3 = product
            .OrderByDescending(n => n.Price)
            .Take(3);

            foreach (var item in top_3)
            {
                Console.WriteLine(item);
            }
            

            //3. Group products by Category
            var grp_ctgry = product.GroupBy(e => e.Category);
            foreach (var item in grp_ctgry)
            {
                Console.WriteLine(item.Key);
                foreach (var item1 in item)
                {
                    Console.WriteLine(item1);
                }
                Console.WriteLine();
            }
            

            //4. Get total stock per category
            var stock_count = from i in product
                              group i by i.Category into grp
                              select new
                              {
                                  Category = grp.Key,
                                  count = grp.Sum(x => x.Stock)

                              }
            ;
            foreach (var item in stock_count)
            {
                Console.WriteLine(item);
            }

            */

            //5. Check if any product is out of stock
            var check_stock = product.Where(e => e.Stock == 0);
            foreach (var item in check_stock)
            {
                Console.WriteLine(item);
            }
        }
    }
}