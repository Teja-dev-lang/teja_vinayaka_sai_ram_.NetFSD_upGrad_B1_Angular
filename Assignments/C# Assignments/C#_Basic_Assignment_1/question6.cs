using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignment_1
{
    internal class question6
    {
        public static void Main()
        {
            //Write an algorithm for calculating the area of rectangle and square separately.
            Console.WriteLine("Area of Rectangle");
            Console.WriteLine("Enter the length of Rectangle");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Breadth of Rectangle");
            double breadth = double.Parse(Console.ReadLine());

            double area_of_rectangle = length * breadth;

            Console.WriteLine(area_of_rectangle);

            Console.WriteLine("Enter the Side of the Square: ");
            double side = double.Parse(Console.ReadLine());
            double area_of_square = side * side;

            Console.WriteLine(area_of_square);
        }
    }
}
