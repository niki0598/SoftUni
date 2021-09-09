using System;

namespace _06.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            const double cake = 45;
            const double waffle = 5.80;
            const double pancake = 3.20;

            int campaignDays = int.Parse(Console.ReadLine());
            int numberOfCookers = int.Parse(Console.ReadLine());
            int numberOfCakes = int.Parse(Console.ReadLine());
            int numberOfWaffles = int.Parse(Console.ReadLine());
            int numberOfPancakes = int.Parse(Console.ReadLine());

            double cakeTotalPrice = numberOfCakes * cake;
            double wafflesTotalPrice = numberOfWaffles * waffle;
            double pancakeTotalPrice = numberOfPancakes * pancake;

            double totalSumForDay = (cakeTotalPrice + wafflesTotalPrice + pancakeTotalPrice) * numberOfCookers;
            double totalSumForCampaign = campaignDays * totalSumForDay;
            double finalSum = totalSumForCampaign - (totalSumForCampaign / 8);

            Console.WriteLine(finalSum);
        }
    }
}
