using System;

namespace _08.NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int biggest = int.MinValue;
            int smallest = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum > biggest)
                {
                    biggest = currentNum;
                }

                if (currentNum < smallest)
                {
                    smallest = currentNum;
                }
            }

            Console.WriteLine($"Max number: {biggest}");
            Console.WriteLine($"Min number:a {smallest}");
        }
    }
}
