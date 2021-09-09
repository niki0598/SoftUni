using System;

namespace _03.OddOrEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += number;

                    if (number < evenMin)
                    {
                        evenMin = number;
                    }

                    if (number > evenMax)
                    {
                        evenMax = number;
                    }
                }
                else
                {
                    oddSum += number;
                    if (number < oddMin)
                    {
                        oddMin = number;
                    }

                    if (number > oddMax)
                    {
                        oddMax = number;
                    }
                }
            }

            Console.WriteLine($"OddSum={oddSum:f2},");

            if (oddSum == 0)
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
            }

            Console.WriteLine($"EvenSum={evenSum:f2},");

            if (evenSum == 0)
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
        }
    }
}
