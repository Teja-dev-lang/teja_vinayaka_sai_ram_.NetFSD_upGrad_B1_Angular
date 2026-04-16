using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace C__LINQ
{
    public record Customer(int Id, string Name);
    public record Orders(int Id, int CustomerId, double Amount);

    internal class Order_Customer
    {
        static void Main()
        {
            var customers = new List<Customer>
            {
                new Customer(1, "Teja"),
                new Customer(2, "Rahul"),
                new Customer(3, "Anjali")
            };

            var orders = new List<Orders>
            {
                new Orders(101, 1, 2500),
                new Orders(102, 2, 1500),
                new Orders(103, 1, 3000),
                new Orders(104, 3, 2000)
            };


            /*
            var result = from c in customers
                         join o in orders
                         on c.Id equals o.CustomerId
                         group o by c.Id into grp
                         select new
                         {
                             Name = grp.Key,
                             TotalAmount = grp.Sum(x => x.Amount)
                         };
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} - {item.TotalAmount}");
            }

            

            //3. Get customers with total orders > 5000

            var totalorder_greater = (from c in customers
                                      join o in orders
                                      on c.Id equals o.CustomerId
                                      group o by c.Id into grp
                                      select new
                                      {
                                          Name = grp.Key,
                                          TotalOrder = grp.Sum(e => e.Amount)
                                      }).Where(e => e.TotalOrder > 500);
            foreach (var item in totalorder_greater)
            {
                Console.WriteLine(item);
            }

            */

            //4. Get customers who have no orders
            var zero_Orders = from c in customers
                              join o in orders
                             on c.Id equals o.CustomerId into grp
                             where !grp.Any()
                              select new
                              {
                                  Name = c.Name,
                                  TotalAmount = grp.Sum(x => x.Amount)  
                              };
            foreach (var item in zero_Orders)
            {
                Console.WriteLine(item);
            }


        }
       
    }
}
