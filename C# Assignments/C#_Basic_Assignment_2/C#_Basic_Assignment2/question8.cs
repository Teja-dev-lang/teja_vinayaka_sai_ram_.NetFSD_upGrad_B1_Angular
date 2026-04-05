using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignment2
{
    internal class question8
    {
        public static void Main() {
            //8Write a program to print the series: 0,1,4,9,16,.....625
            int n = 25;
            int[] numbers = new int[26]; 

            for (int i=0; i <= n; i++)
            {
                numbers[i] = i * i;
                if (i < n)
                    Console.Write(numbers[i] + ",");
                else
                    Console.Write(numbers[i]);
            }
            
        }
    }
}
