using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace C__Basic_Assignment2
{
    internal class question4

    {
        public static void Main()
        {
            //4.Accept a number from the user and display whether the given number is an odd number or even number.
            Console.WriteLine("ENter the Number :");
            int num = int.Parse(Console.ReadLine());

            String result = num % 2 == 0 ? "Even" : "ODD";
            Console.WriteLine(result);
        }
    }
}
