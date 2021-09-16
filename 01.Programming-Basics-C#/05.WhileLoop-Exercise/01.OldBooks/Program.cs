using System;

namespace _01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            string nextBook = Console.ReadLine();
            int counter = 0;

            while (nextBook != "No More Books")
            {
                if (nextBook == favoriteBook)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    break;
                }
                counter++;
                nextBook = Console.ReadLine();
            }

            if (favoriteBook != nextBook)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
