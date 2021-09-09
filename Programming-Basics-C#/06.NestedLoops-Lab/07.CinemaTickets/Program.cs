using System;

namespace _07.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Finish")
                {
                    break;
                }

                int freeSpots = int.Parse(Console.ReadLine());
                int currentFreeSpots = freeSpots;

                while (currentFreeSpots > 0)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "End")
                    {
                        break;
                    }

                    currentFreeSpots--;

                    if (ticketType == "standard")
                    {
                        standardTickets++;
                    }
                    else if (ticketType == "student")
                    {
                        studentTickets++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidTickets++;
                    }
                }
                double freeSpotsInPercentage = 100 - (currentFreeSpots * 1.0 / freeSpots * 100);

                Console.WriteLine($"{input} - {freeSpotsInPercentage:f2}% full.");
            }

            int totalTickets = standardTickets + studentTickets + kidTickets;
            double studentsTicketsPercentage = studentTickets * 1.0 / totalTickets * 100;
            double standardTicketsPercentage = standardTickets * 1.0 / totalTickets * 100;
            double kidsTicketsPercentage = kidTickets * 1.0 / totalTickets * 100;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentsTicketsPercentage:f2}% student tickets.");
            Console.WriteLine($"{standardTicketsPercentage:f2}% standard tickets.");
            Console.WriteLine($"{kidsTicketsPercentage:f2}% kids tickets.");
        }
    }
}
