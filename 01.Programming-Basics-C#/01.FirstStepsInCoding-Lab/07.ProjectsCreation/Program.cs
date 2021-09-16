using System;

namespace _07.ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTheArchitect = Console.ReadLine();
            int countOfProject = int.Parse(Console.ReadLine());

            int timeNeededForOneProject = 3;
            int timeNeedeMultipleForProjects = countOfProject * timeNeededForOneProject;

            Console.WriteLine($"The architect {nameOfTheArchitect} will need {timeNeedeMultipleForProjects} hours to complete {countOfProject} project/s.");
        }
    }
}