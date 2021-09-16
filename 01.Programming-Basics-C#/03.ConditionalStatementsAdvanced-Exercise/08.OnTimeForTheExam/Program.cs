using System;

namespace _08.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinutes = int.Parse(Console.ReadLine());

            int difference = 0;
            int hour = 0;
            int minutes = 0;

            examMinutes += examHour * 60;
            arriveMinutes += arriveHour * 60;

            if (arriveMinutes > examMinutes)
            {
                Console.WriteLine("Late");
                difference = arriveMinutes - examMinutes;

                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours after the start");
                }
            }
            else if (arriveMinutes < examMinutes - 30)
            {
                Console.WriteLine("Early");
                difference = examMinutes - arriveMinutes;

                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours before the start");
                }
            }
            else
            {
                Console.WriteLine("On time");
                difference = examMinutes - arriveMinutes;
                Console.WriteLine($"{difference} minutes before the start");
            }
        }
    }
}
