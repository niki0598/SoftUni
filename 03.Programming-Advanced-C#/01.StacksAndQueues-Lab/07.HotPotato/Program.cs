using System;
using System.Collections.Generic;

namespace _07.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kidsNames = Console.ReadLine().Split(" ");
            int nthToss = int.Parse(Console.ReadLine());
            Queue<string> kids = new Queue<string>(kidsNames);

            while (kids.Count > 1)
            {
                for (int i = 0; i < nthToss - 1; i++)
                {
                    string potatoKid = kids.Dequeue();
                    kids.Enqueue(potatoKid);
                }
                Console.WriteLine($"Removed {kids.Dequeue()}");
            }

            Console.WriteLine($"Last is {kids.Peek()}");
        }
    }
}
