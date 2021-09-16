using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
            Queue<int> evenNumbers = new Queue<int>();

            while (queue.Count > 0)
            {
                int numberCheck = queue.Dequeue();
                if (numberCheck % 2 == 0)
                {
                    evenNumbers.Enqueue(numberCheck);
                }
            }
            Console.Write(string.Join(", ", evenNumbers));
        }
    }
}
