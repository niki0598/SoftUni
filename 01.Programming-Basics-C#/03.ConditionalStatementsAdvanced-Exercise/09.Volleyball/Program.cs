using System;

namespace _09.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double p = int.Parse(Console.ReadLine());
            double h = int.Parse(Console.ReadLine());

            double weekends = 48;
            double gamesPerWeekend = 0;
            double holidays = 0;
            double leapYear = 0;
            double sum = 0;

            switch (year)
            {
                case "leap":
                    weekends -= h;
                    gamesPerWeekend = weekends * 3 / 4;
                    holidays = p * 2 / 3;
                    leapYear = (gamesPerWeekend + holidays + h) * 0.15;
                    sum = gamesPerWeekend + holidays + h + leapYear;
                    break;
                case "normal":
                    weekends -= h;
                    gamesPerWeekend = weekends * 3 / 4;
                    holidays = p * 2 / 3;
                    sum = gamesPerWeekend + holidays + h;
                    break;
            }

            Console.WriteLine($"{Math.Floor(sum)}");
        }
    }
}
