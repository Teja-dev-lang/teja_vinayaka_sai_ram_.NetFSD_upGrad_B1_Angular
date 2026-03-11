using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignment_1
{
    internal class question4
    {
        static void Main()
        {
            //Write an algorithm for accepting a number and display the whether it is odd or even.
            Console.WriteLine("Enter the Number : ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is Even Number");
            }
            else
            {
                Console.WriteLine($"{num} is ODD Number");
            }
        }
    }
}
