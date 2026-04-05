using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignment_1
{
    internal class question5
    {
        //Write an algorithm for accepting two numbers and display the highest number among two.
        public static void Main()
        {
            Console.WriteLine("Enter the first Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine($"{a} is greater than {b}");

            }
            else if (a == b)
            {
                Console.WriteLine($"{a} and {b} are EQual");

            }
            else
            {
                Console.WriteLine($"{b} is greater than {a}");

            }
        }
    }
}
