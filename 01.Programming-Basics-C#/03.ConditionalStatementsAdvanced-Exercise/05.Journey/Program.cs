using System;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double moneySpent = 0;

            switch (season)
            {
                case "summer":
                    if (budget <= 100)
                    {
                        Console.WriteLine("Somewhere in Bulgaria");
                        moneySpent = budget * 0.3;
                        Console.WriteLine($"Camp - {moneySpent:f2}");
                    }
                    else if (budget <= 1000)
                    {
                        Console.WriteLine("Somewhere in Balkans");
                        moneySpent = budget * 0.4;
                        Console.WriteLine($"Camp - {moneySpent:f2}");
                    }
                    else if (budget > 1000)
                    {
                        Console.WriteLine("Somewhere in Europe");
                        moneySpent = budget * 0.9;
                        Console.WriteLine($"Hotel - {moneySpent:f2}");
                    }
                    break;
                case "winter":
                    if (budget <= 100)
                    {
                        Console.WriteLine("Somewhere in Bulgaria");
                        moneySpent = budget * 0.7;
                        Console.WriteLine($"Hotel - {moneySpent:f2}");
                    }
                    else if (budget <= 1000)
                    {
                        Console.WriteLine("Somewhere in Balkans");
                        moneySpent = budget * 0.8;
                        Console.WriteLine($"Hotel - {moneySpent:f2}");
                    }
                    else if (budget > 1000)
                    {
                        Console.WriteLine("Somewhere in Europe");
                        moneySpent = budget * 0.9;
                        Console.WriteLine($"Hotel - {moneySpent:f2}");
                    }
                    break;
            }
        }
    }
}
