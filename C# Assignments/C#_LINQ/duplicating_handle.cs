using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace C__LINQ
{
    internal class duplicating_handle
    {
        public static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 2, 4, 5, 3, 6 };

            /*
            //remove duplicates
            var rm_duplicate = numbers.Distinct();
            foreach (var item in rm_duplicate)
            {
                Console.WriteLine(item);
            }

           

            //Find duplicates values
            var duplicate_val = (numbers
                .GroupBy(e => e)
                .Where(e => e.Count() > 1)).SelectMany(g => g).Distinct();
            foreach (var item in duplicate_val)
            {
                Console.WriteLine(item);
            }

            

            //Count occurrence of each number
            var occurance = from n in numbers
                            group n by n into grp
                            select new
                            {
                                Number = grp.Key,
                                count = grp.Count()
                            };
            foreach (var item in occurance)
            {
                Console.WriteLine(item);
            }
            */
           
        }
    }
}
