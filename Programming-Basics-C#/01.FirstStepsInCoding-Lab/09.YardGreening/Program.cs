using System;

namespace _09.YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double countOfMetersGreening = double.Parse(Console.ReadLine());

            double priceofOneSquareMeter = 7.61;

            double price = countOfMetersGreening * priceofOneSquareMeter;
            double discount = 0.18 * price;

            double finalPrice = price - discount; 

            Console.WriteLine($"The final price is: {finalPrice} lv." );
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}