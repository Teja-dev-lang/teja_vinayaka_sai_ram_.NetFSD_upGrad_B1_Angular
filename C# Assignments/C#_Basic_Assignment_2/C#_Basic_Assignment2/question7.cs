using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignment2
{
    internal class question7
    {
        public static void Main()
        {
            //	A shopkeeper sells three products whose retail prices are as follows:
            //	Product 1, 22.5;
            //	product 2, 44.50; and
            //	product 3, 9.98.
            //	Write an application that reads a series of pairs of numbers as follows:
            //a)product number
            //b)quantity sold
            //and calculate the total price.
            double total = 0;

            Console.WriteLine("Enter Product Number:");
            int product = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Quantity Sold:");
            int quantity = int.Parse(Console.ReadLine());

            switch (product)
            {
                case 1:
                    total = quantity * 22.5;
                    break;

                case 2:
                    total = quantity * 44.50;
                    break;

                case 3:
                    total = quantity * 9.98;
                    break;

                default:
                    Console.WriteLine("Invalid Product Number");
                    return;
            }

            Console.WriteLine("Total Price = " + total);
        }


    }
}
