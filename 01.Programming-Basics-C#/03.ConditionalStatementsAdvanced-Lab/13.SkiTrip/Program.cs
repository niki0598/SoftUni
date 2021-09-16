using System;
using System.Runtime.ConstrainedExecution;

namespace _13.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string premises = Console.ReadLine();
            string note = Console.ReadLine();

            int nights = days - 1;
            double price = 0;
            double roomPrice = 0;
            double finalPrice = 0;

            switch (premises)
            {
                case "room for one person":

                    roomPrice = nights * 18.00;

                    break;

                case "apartment":

                    price = nights * 25;

                    if (nights < 10)
                    {
                        roomPrice = price - price * 0.3;
                    }
                    else if (10 <= nights && nights <= 15)
                    {
                        roomPrice = price - price * 0.35;
                    }
                    else if (nights > 15)
                    {
                        roomPrice = price - price * 0.5;
                    }
                    break;

                case "president apartment":

                    price = nights * 35;

                    if (nights < 10)
                    {
                        roomPrice = price - price * 0.1;
                    }
                    else if (10 <= nights && nights <= 15)
                    {
                        roomPrice = price - price * 0.15;
                    }
                    else if (nights > 15)
                    {
                        roomPrice = price - price * 0.2;
                    }
                    break;
            }

            if (days <= 1)
            {
                finalPrice = 0;
            }
            else
            {
                if (note == "positive")
                {
                    finalPrice = roomPrice + roomPrice * 0.25;
                }
                else if (note == "negative")
                {
                    finalPrice = roomPrice - roomPrice * 0.10;
                }
            }
            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}
