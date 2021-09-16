using System;

namespace _04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermans = int.Parse(Console.ReadLine());

            double rentPrice = 0;
            double finalPrice = 0;

            switch (season)
            {
                case "Spring":
                    rentPrice = 3000;
                    if (fishermans <= 6)
                    {
                        finalPrice = rentPrice - rentPrice * 0.1;
                    }
                    else if (7 <= fishermans && fishermans <= 11)
                    {
                        finalPrice = rentPrice - rentPrice * 0.15;
                    }
                    else if (fishermans >= 12)
                    {
                        finalPrice = rentPrice - rentPrice * 0.25;
                    }

                    break;
                case "Summer":
                    rentPrice = 4200;
                    if (fishermans <= 6)
                    {
                        finalPrice = rentPrice - rentPrice * 0.1;
                    }
                    else if (7 <= fishermans && fishermans <= 11)
                    {
                        finalPrice = rentPrice - rentPrice * 0.15;
                    }
                    else if (fishermans >= 12)
                    {
                        finalPrice = rentPrice - rentPrice * 0.25;
                    }
                    break;
                case "Autumn":
                    rentPrice = 4200;
                    if (fishermans <= 6)
                    {
                        finalPrice = rentPrice - rentPrice * 0.1;
                    }
                    else if (7 <= fishermans && fishermans <= 11)
                    {
                        finalPrice = rentPrice - rentPrice * 0.15;
                    }
                    else if (fishermans >= 12)
                    {
                        finalPrice = rentPrice - rentPrice * 0.25;
                    }
                    break;
                case "Winter":
                    rentPrice = 2600;
                    if (fishermans <= 6)
                    {
                        finalPrice = rentPrice - rentPrice * 0.1;
                    }
                    else if (7 <= fishermans && fishermans <= 11)
                    {
                        finalPrice = rentPrice - rentPrice * 0.15;
                    }
                    else if (fishermans >= 12)
                    {
                        finalPrice = rentPrice - rentPrice * 0.25;
                    }
                    break;
            }

            if (season != "Autumn" && fishermans % 2 == 0)
            {
                finalPrice -= finalPrice * 0.05;
            }

            if (budget >= finalPrice)
            {
                Console.WriteLine($"Yes! You have {budget - finalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {finalPrice - budget:f2} leva.");
            }
        }
    }
}
