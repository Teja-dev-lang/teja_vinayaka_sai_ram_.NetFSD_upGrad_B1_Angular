using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace C__Basic_Assignment2
{
    internal class question2
    {
        //	Write a program in C# to accept the name of the user as a command line argument and greet the user as:
        //“Hi! username
        //Welcome to the world of C#”
        public static void Main()
        {
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();

            Console.WriteLine($"Hi! {name}\n" +
                $"Welcome to the world of C#");
        }

    }
}
