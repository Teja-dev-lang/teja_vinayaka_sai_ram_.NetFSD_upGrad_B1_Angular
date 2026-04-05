using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace C__LINQ
{
    internal class NumberCollection
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 5, 10, 15, 20, 25, 30 };

            var result1 = from n in numbers
                          where n % 2 == 0 && n > 15
                          let m = n * n
                          where m % 5 ==0
                          select m;
            int count = result1.Count();
            Console.WriteLine(count);
            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
