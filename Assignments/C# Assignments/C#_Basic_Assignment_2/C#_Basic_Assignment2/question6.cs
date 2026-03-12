using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignment2
{
    internal class question6
    {
        public static void Main()
        {
            //6.Write a program in C# to display temperature in Celsius. Accept the temperature in Fahrenheit.
            Console.WriteLine("Enter the Temperature of Farenheit :");
            double far = double.Parse(Console.ReadLine());

            double con_celi = (5.0 / 9) * (far - 32);
            Console.WriteLine($"The Conversion of Farenheit of {far} F to Celsius is {con_celi} C");
        }
    }
}
