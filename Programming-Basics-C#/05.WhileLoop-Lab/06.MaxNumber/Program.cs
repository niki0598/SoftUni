using System;

namespace _06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int biggestNumber = int.MinValue;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Stop")
                {
                    break;
                }

                int k = int.Parse(input);

                if (k > biggestNumber)
                {
                    biggestNumber = k;
                }
            }

            Console.WriteLine(biggestNumber);
        }
    }
}
