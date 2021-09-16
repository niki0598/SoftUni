using System;
using System.Collections.Generic;

namespace _03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] problem = Console.ReadLine().Split(' ');
            Stack<int> stack = new Stack<int>();

            stack.Push(int.Parse(problem[0]));

            for (int i = 0; i < problem.Length - 1; i++)
            {
                int previousNumber = 0;
                int currentNumber = 0;

                if (problem[i] == "+")
                {
                    previousNumber = stack.Pop();
                    currentNumber = previousNumber + int.Parse(problem[i + 1]);
                    stack.Push(currentNumber);
                }
                else if (problem[i] == "-")
                {
                    previousNumber = stack.Pop();
                    currentNumber = previousNumber - int.Parse(problem[i + 1]);
                    stack.Push(currentNumber);
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
