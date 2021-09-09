using System;

namespace _07.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pricePuzzle = 2.60;
            const int priceTalkingDoll = 3;
            const double priceTeddyBear = 4.10;
            const double priceMinion = 8.20;
            const int priceTruck = 2;

            double priceForTrip = double.Parse(Console.ReadLine());
            int countofPuzzles = int.Parse(Console.ReadLine());
            int countofTalkingDolls = int.Parse(Console.ReadLine());
            int countofTeddyBears = int.Parse(Console.ReadLine());
            int countofMinions = int.Parse(Console.ReadLine());
            int countofTrucks = int.Parse(Console.ReadLine());

            int countOfToys = countofPuzzles + countofTalkingDolls + countofTeddyBears + countofMinions + countofTrucks;
            double sum = countofPuzzles * pricePuzzle + countofTalkingDolls * priceTalkingDoll + countofTeddyBears *
                priceTeddyBear + countofMinions * priceMinion + countofTrucks * priceTruck;
            double discount = 0;

            if (countOfToys >= 50)
            {
                discount = sum * 0.25;
                
            }

            double sumFinal = sum - discount;
            double rent = sumFinal * 0.10;
            double moneyMade = sumFinal - rent;

            if(priceForTrip > moneyMade)
            {
                double moneyNeeded = priceForTrip - moneyMade;
                Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");
            }
            else
            {
                double moneyLeft = moneyMade - priceForTrip;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");                   
            }
        }
    }
}
