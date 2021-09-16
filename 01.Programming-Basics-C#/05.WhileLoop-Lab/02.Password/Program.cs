using System;

namespace _02.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string myPassword = Console.ReadLine();
            string inputPassword = Console.ReadLine();

            while (inputPassword != myPassword)
            {
                inputPassword = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {username}!");
        }
    }
}
