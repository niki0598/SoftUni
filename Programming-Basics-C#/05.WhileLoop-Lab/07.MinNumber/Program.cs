using System;

namespace _07.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int smallestNumber = int.MaxValue;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Stop")
                {
                    break;
                }

                int k = int.Parse(input);

                if (k < smallestNumber)
                {
                    smallestNumber = k;
                }
            }

            Console.WriteLine(smallestNumber);
        }
    }
}
