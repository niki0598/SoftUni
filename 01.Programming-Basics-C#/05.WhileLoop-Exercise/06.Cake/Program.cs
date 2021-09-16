using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int cakePieces = length * width;

            string commands = Console.ReadLine();

            while (cakePieces >= 0)
            {
                if (commands == "STOP")
                {
                    break;
                }
                int cake = int.Parse(commands);
                cakePieces -= cake;
                commands = Console.ReadLine();
            }

            if (cakePieces >= 0)
            {
                Console.WriteLine($"{cakePieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakePieces)} pieces more.");
            }
        }
    }
}
