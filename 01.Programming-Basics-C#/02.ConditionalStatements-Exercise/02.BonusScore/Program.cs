using System;

namespace _02.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            double bonus;

            if (number <= 100)
            {
                bonus = 5;
            }
            else if (number > 1000)
            {
                bonus = number * 0.10;
            }
            else
            {
                bonus = number * 0.20;
            }

            if (number % 2 == 0)
            {
                bonus++;
            }
            else if (number % 10 == 5)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);

            double finalSum = number + bonus;

            Console.WriteLine(finalSum);
        }
    }
}
