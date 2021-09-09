using System;

namespace _09.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            bool hasSpace = true;

            int volume = x * y * z;

            while (hasSpace && input != "Done")
            {
                int boxes = int.Parse(input);
                volume -= boxes;

                if (volume < 0)
                {
                    hasSpace = false;
                    break;
                }
                input = Console.ReadLine();
            }

            if (hasSpace)
            {
                Console.WriteLine($"{volume} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
            }
        }
    }
}
