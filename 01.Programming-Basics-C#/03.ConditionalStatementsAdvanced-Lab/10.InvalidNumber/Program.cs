using System;

namespace _10.InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                return;
            }

            if (number < 100 || number > 200)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
