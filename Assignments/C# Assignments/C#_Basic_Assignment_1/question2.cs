using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using System.Text;

namespace C__Basic_Assignment_1
{
    internal class question2
    {
        public static void Main()
        {
            //Write an algorithm for accepting distance in kilometers, convert it into meters and display the result.

            Console.WriteLine("------------Conversion of Distance Kiometer(KM) into Meters(M)--------------");
            Console.WriteLine("Enter the Kilometer");
            double kilometer = double.Parse(Console.ReadLine());
            double conv_Meters = kilometer * 1000;
            Console.WriteLine($"Conversion of {kilometer} KM to Meters is {conv_Meters} M");
        }
    }
}
