using System;

namespace _05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = 0;
            string input = Console.ReadLine();

            while (input != "NoMoreMoney")
            {
                double deposit = double.Parse(input);

                if (deposit <= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    balance += deposit;
                    Console.WriteLine($"Increase: {deposit:f2}");
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
