using System;

namespace _01.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeA = int.Parse(Console.ReadLine());
            int timeB = int.Parse(Console.ReadLine());
            int timeC = int.Parse(Console.ReadLine());

            int totalTime = timeA + timeB + timeC;

            int seconds = totalTime % 60;
            int minutes = totalTime / 60;

            Console.WriteLine($"{minutes}:{seconds:d2}");
        }
    }
}
