using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignment_1
{
    internal class question3
    {
        static void Main() {
            //Write an algorithm for accepting five numbers and display the sum and average of the numbers.

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int sum_num = a + b + c + d;

            double avg = sum_num / 4;

            Console.WriteLine($"Sum of the Numbers is : {sum_num}");
            Console.WriteLine($"Average of Numbers is : {avg}");
         }

    }
}
