using System;

namespace _03.DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            int interestInMonth = int.Parse(Console.ReadLine());
            double annualInterest = double.Parse(Console.ReadLine());

            double interest = (amount * annualInterest) / 100;
            double interestPerMonth = interest / 12;
            double totalSum = amount + interestInMonth * interestPerMonth; 

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
