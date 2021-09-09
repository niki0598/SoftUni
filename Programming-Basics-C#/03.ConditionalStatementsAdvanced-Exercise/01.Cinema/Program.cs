using System;

namespace _01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double totalMoney = 0;

            switch (type)
            {
                case "Premiere":
                    totalMoney = rows * columns * 12;
                    break;
                case "Normal":
                    totalMoney = rows * columns * 7.5;
                    break;
                case "Discount":
                    totalMoney = rows * columns * 5;
                    break;
            }

            Console.WriteLine($"{totalMoney:f2} leva");
        }
    }
}
