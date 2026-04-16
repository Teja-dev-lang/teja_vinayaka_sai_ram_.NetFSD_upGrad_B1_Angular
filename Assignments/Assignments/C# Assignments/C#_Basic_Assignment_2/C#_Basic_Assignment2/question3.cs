using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace C__Basic_Assignment2
{
    internal class question3
    {
        public static void Main()
        {
            //3.Write a program in C# to accept two numbers as command line argument and
            //display all the numbers between the given two numbers.
            Console.WriteLine("Enter the FirstNumber :");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the SecondNumber :");
            int b = int.Parse(Console.ReadLine());

            int greater;
            int smaller;
            if (a == b)
            {
                Console.WriteLine($"No Numbers in Between");
                return;
            }
            else if (a > b)
            {
                greater = a;
                smaller = b;
            }
            else
            {
                greater = b;
                smaller = a;
            }
            greater--;
            while (smaller < greater)
            {
                smaller += 1;
                Console.WriteLine(smaller);
            }

        }
    }
}
