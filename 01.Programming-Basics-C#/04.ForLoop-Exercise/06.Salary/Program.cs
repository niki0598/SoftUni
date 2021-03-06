using System;

namespace _06.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            const int instagram = 100;
            const int facebook = 150;
            const int reddit = 50;

            int openedTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i <= openedTabs; i++)
            {
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }

                string browsers = Console.ReadLine();

                if (browsers == "Facebook")
                {
                    salary -= facebook;
                }
                else if (browsers == "Instagram")
                {
                    salary -= instagram;
                }
                else if (browsers == "Reddit")
                {
                    salary -= reddit;
                }
            }

            if (salary > 0)
            {
                Console.WriteLine($"{salary}");
            }
        }
    }
}
