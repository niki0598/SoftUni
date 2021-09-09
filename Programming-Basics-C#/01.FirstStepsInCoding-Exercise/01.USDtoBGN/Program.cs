using System;

namespace _01.USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double dollarsCourse = 1.79549;
            double dollars = double.Parse(Console.ReadLine());
            double convertedToBGN = dollars * dollarsCourse;

            Console.WriteLine($"{convertedToBGN:f2}");
        }
    }
}
