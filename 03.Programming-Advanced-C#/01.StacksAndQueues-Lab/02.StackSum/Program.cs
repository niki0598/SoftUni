using System;
using System.Collections.Generic;

namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            Stack<int> stack = new Stack<int>();

            foreach (var number in numbers)
            {
                stack.Push(int.Parse(number));
            }

            while (true)
            {
                string command = Console.ReadLine().ToLower();
                string[] commandArgs = command.Split(' ');

                if (commandArgs[0] == "end")
                {
                    break;
                }
                else if (commandArgs[0] == "add")
                {
                    stack.Push(int.Parse(commandArgs[1]));
                    stack.Push(int.Parse(commandArgs[2]));
                }
                else if (commandArgs[0] == "remove")
                {
                    int numbersToRemove = int.Parse(commandArgs[1]);
                    if (numbersToRemove > stack.Count)
                    {
                        continue;
                    }

                    for (int i = 0; i < numbersToRemove; i++)
                    {
                        stack.Pop();
                    }
                }
            }

            int sum = 0;
            int stackCount = stack.Count;
            for (int i = 0; i < stackCount; i++)
            {
                sum += stack.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
