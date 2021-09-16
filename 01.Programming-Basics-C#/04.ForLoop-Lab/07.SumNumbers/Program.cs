using System;

namespace _07.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int f = int.Parse(Console.ReadLine());
                sum += f;
            }

            Console.WriteLine(sum);
        }
    }
}
