using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int poorGradesLimit = int.Parse(Console.ReadLine());
            string task = Console.ReadLine();
            int poorGradesCount = 0;
            int gradesCounter = 0;
            int score = 0;
            string lastProblem = "";
            bool isPerfect = true;

            while (task != "Enough")
            {
                lastProblem = task;
                int grade = int.Parse(Console.ReadLine());
                gradesCounter++;
                score += grade;

                if (grade <= 4)
                {
                    poorGradesCount++;

                    if (poorGradesCount >= poorGradesLimit)
                    {
                        isPerfect = false;
                        break;
                    }
                }
                task = Console.ReadLine();
            }

            double avgScore = 1.0 * score / gradesCounter;

            if (isPerfect)
            {
                Console.WriteLine($"Average score: {avgScore:f2}");
                Console.WriteLine($"Number of problems: {gradesCounter}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            else
            {
                Console.WriteLine($"You need a break, {poorGradesCount} poor grades.");
            }
        }
    }
}
