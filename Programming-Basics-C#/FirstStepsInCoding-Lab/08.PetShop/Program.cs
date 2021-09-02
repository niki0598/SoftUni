using System;

namespace _08.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfDogs = int.Parse(Console.ReadLine());
            int countOfOtherAnimals = int.Parse(Console.ReadLine());

            double dogFood = 2.50;
            double otherAnimalsFood = 4;

            double sum = (countOfDogs * dogFood) + (countOfOtherAnimals * otherAnimalsFood);

            Console.WriteLine($"{sum} lv.");
        }
    }
}