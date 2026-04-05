using System;
using System.Collections.Generic;
using System.Text;

namespace C__LINQ
{
    internal class StringOperations
    {
        static void Main()
        {
            List<string> names = new List<string> { "Ravi", "Kiran", "Amit", "Raj", "Anil" };

            //1. Get names starting with 'A'
            var result = from i in names
                         where i.StartsWith('A')
                         select i;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var result1 = names.Where(e => e.StartsWith("A"));
            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
