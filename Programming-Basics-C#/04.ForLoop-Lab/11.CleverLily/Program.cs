using System;

namespace _11.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWM = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());

            double savings = 0;
            double presentMoney = 10;
            int toys = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savings += presentMoney;
                    presentMoney += 10;
                    savings -= 1;
                }
                else
                {
                    toys += 1;
                }
            }

            savings += toys * toysPrice;

            if (priceWM <= savings)
            {
                Console.WriteLine($"Yes! {savings - priceWM:f2}");
            }
            else
            {
                Console.WriteLine($"No! {priceWM - savings:f2}");
            }
        }
    }
}
