using System;

namespace _05.Travelling
{
    class Travelling
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string country = Console.ReadLine();

                if (country == "End")
                {
                    break;
                }

                double budget = double.Parse(Console.ReadLine());
                double savedMoney = 0;

                while (savedMoney < budget)
                {
                    double income = double.Parse(Console.ReadLine());

                    savedMoney += income;
                }

                Console.WriteLine($"Going to {country}!");
            }
        }
    }
}
