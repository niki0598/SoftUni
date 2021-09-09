using System;

namespace _04.VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentBookPages = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int daysPerBook = int.Parse(Console.ReadLine());

            double totalBookTime = currentBookPages / pagesPerHour;
            double hoursPerDay = totalBookTime / daysPerBook;

            Console.WriteLine(hoursPerDay);
        }
    }
}
