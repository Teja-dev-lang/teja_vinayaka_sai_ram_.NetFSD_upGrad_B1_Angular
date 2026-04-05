using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace C__Basic_Assignment_1
{
    internal class Question1
    {
        //Write an algorithm for accepting two numbers, divide the first number by second and display their quotient.
        public static void Main()
        {
            Console.WriteLine("Enter the First Number: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Second Number: ");
            int b = int.Parse(Console.ReadLine());

            double result = (double)a / b;
            Console.WriteLine($"The Division of {a} and {b} is {result}");
        }



    }
}
