using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            int days = 0;
            int daysSpent = 0;

            while (availableMoney < moneyNeeded)
            {
                days++;

                string input = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());

                if (input == "spend")
                {
                    daysSpent++;
                    if (daysSpent == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{days}");
                        break;
                    }

                    availableMoney -= money;

                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                }
                else if (input == "save")
                {
                    daysSpent = 0;
                    availableMoney += money;
                }
            }

            if (availableMoney >= moneyNeeded)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}
