using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignment2
{
    internal class question9
    {
        public static void Main()
        {
            Console.WriteLine("Enter the Number for Check Factorial : ");
            int fact = int.Parse(Console.ReadLine());
            if (fact <= 0)
            {
                Console.WriteLine("The Number is Must greater than zero");
                return;
            }
            int n = fact;
            int sum = 1;
            while (n > 0)
            {
                sum *= n;
                n--;
            }
            Console.WriteLine($"The FActorial of Number {fact} is {sum}");
        }
    }
}
