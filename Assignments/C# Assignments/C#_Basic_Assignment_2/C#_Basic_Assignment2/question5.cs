using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignment2
{
    internal class question5
    {
        public static void Main()
        {
            //5.Write a program in C# to find the total number of odd
            //and even numbers accepted from the user.
            Console.WriteLine("How Many Numbers Wanted to Enter :");
            int n = int.Parse(Console.ReadLine());

            int evencount = 0;
            int oddcount = 0;

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the Number :");
                int m = int.Parse(Console.ReadLine());

                if (m % 2 == 0)
                {
                    evencount++;
                }
                else
                {
                    oddcount++;
                }

            }

            Console.WriteLine("EVEN :"+evencount);
            Console.WriteLine("ODD :"+oddcount);

        }
    }
}
