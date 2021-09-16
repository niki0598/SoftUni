using System;

namespace _03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double finalPrice = 0;
            double moneyLeft = 0;
            double moneyNeeded = 0;

            switch (flowers)
            {
                case "Roses":
                    finalPrice = flowerCount * 5;
                    if (flowerCount > 80)
                    {
                        finalPrice -= finalPrice * 0.1;
                    }
                    break;
                case "Dahlias":
                    finalPrice = flowerCount * 3.8;
                    if (flowerCount > 90)
                    {
                        finalPrice -= finalPrice * 0.15;
                    }
                    break;
                case "Tulips":
                    finalPrice = flowerCount * 2.8;
                    if (flowerCount > 80)
                    {
                        finalPrice -= finalPrice * 0.15;
                    }
                    break;
                case "Narcissus":
                    finalPrice = flowerCount * 3;
                    if (flowerCount < 120)
                    {
                        finalPrice += finalPrice * 0.15;
                    }
                    break;
                case "Gladiolus":
                    finalPrice = flowerCount * 2.5;
                    if (flowerCount < 80)
                    {
                        finalPrice += finalPrice * 0.2;
                    }
                    break;
            }

            if (budget >= finalPrice)
            {
                moneyLeft = budget - finalPrice;
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowers} and {moneyLeft:f2} leva left.");
            }
            else
            {
                moneyNeeded = finalPrice - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
            }
        }
    }
}
