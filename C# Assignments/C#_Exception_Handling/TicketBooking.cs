using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace C__Exception_Handling
{

    public class TicketLimitException : Exception
    {
        public TicketLimitException(string Message) : base(Message) { }
    }
    public class MovieTicket
    {
        static int AvailableTickets = 15;

        public static void Booktickets(int requestedTickets)
        {
            if (requestedTickets > AvailableTickets)
            {
                throw new TicketLimitException("TicketBooking Failed : Not Enough Tickets Available ");
            }
            AvailableTickets -= requestedTickets;
            Console.WriteLine($"You Successfully Booked {requestedTickets} Tickets");
            Console.WriteLine($"Now Avaliable Tickets are {AvailableTickets}");
        }

    }

    internal class TicketBooking
    {
        public static void Main()
        {
            Console.WriteLine("Do you Want to Book the Tickets : (yes / no) ");
            string userinterest = Console.ReadLine();

            if (userinterest.ToLower() == "yes")
            {
                Console.WriteLine("Enter the Tickets Required :");
                int userReq = int.Parse(Console.ReadLine());

                try
                {
                    MovieTicket.Booktickets(userReq);
                }
                catch(TicketLimitException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
