using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string problem = Console.ReadLine();
            Stack<int> indices = new Stack<int>();

            for (int i = 0; i < problem.Length; i++)
            {
                if (problem[i] == '(')
                {
                    indices.Push(i);
                }
                else if (problem[i] == ')')
                {
                    int openBracketIndex = indices.Pop();
                    int closedBracketIndex = i;

                    Console.WriteLine(problem.Substring(openBracketIndex, closedBracketIndex - openBracketIndex + 1));
                }
            }
        }
    }
}
