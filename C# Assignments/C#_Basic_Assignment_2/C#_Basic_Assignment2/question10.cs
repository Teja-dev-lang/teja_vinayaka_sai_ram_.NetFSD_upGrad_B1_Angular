using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignment2
{
    internal class question10
    {
        public static void Main()
        {
            //10.Write a program in C# to generate a Fibonacci series till 40.
            int a = 0;
            int b = 1;
      

            for(int i = 0; i<=40; i++)
            {
                Console.Write(a + ",");
                (a,b) = (b,a+b);
            }
        }
    }
}
