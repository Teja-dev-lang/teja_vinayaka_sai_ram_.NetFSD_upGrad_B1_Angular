using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignment_1
{
    internal class question7
    {
        public static void Main()
        {
                //Write an algorithm for accepting the distance and speed values for a particular journey,
                //calculate the time taken for the journey and display the same.
            Console.WriteLine("Enter the Distance :");
            int distance = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Speed :");
            int Speed = int.Parse(Console.ReadLine());

            double time = distance / Speed;
            Console.WriteLine($"Time taken to Cover the Distance of {distance} with {Speed} speed is {time} hr");





        }
    }
}
