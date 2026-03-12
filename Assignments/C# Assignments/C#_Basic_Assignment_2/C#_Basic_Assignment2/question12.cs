using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignment2
{
    internal class question12
    {
        public static void Main()
        {
            //12.Write a program to print the numbers divisible by 7 between 200 and 300.

            for(int i = 200; i<=300; i++)
            {
                if (i%7 == 0)
                {
                    Console.Write(i + ",");
                }
            }
        }
    }
}
