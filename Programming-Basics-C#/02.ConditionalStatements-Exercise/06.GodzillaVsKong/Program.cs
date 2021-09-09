using System;
using System.Text;

namespace _06.GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double statistOutfit = double.Parse(Console.ReadLine());

            double decore = budget * 0.10;
            double outfitPrice = statists * statistOutfit;

            if (statists > 150)
            {
                outfitPrice -= outfitPrice * 0.10;
            }

            double filmPrice = outfitPrice + decore;

            if (filmPrice > budget)
            {
                Console.WriteLine("Not enough money!");
                double moneyNeeded = filmPrice - budget;
                Console.WriteLine($"Wingard needs {moneyNeeded:f2} leva more.");
            }
            else if (filmPrice <= budget)
            {
                Console.WriteLine("Action!");
                double moneyLeft = budget - filmPrice;
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
        }
    }
}
