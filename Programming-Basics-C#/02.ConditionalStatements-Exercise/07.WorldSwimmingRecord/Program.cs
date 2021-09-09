using System;

namespace _07.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double previousRecordinSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timePerMeterInSeconds = double.Parse(Console.ReadLine());

            double timeNeeded = distanceInMeters * timePerMeterInSeconds;
            double delay = Math.Floor(distanceInMeters / 15) * 12.5;
            double totalTime = timeNeeded + delay;

            if (totalTime < previousRecordinSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                double secondsSlower = totalTime - previousRecordinSeconds;

                Console.WriteLine($"No, he failed! He was {secondsSlower:f2} seconds slower.");
            }
        }
    }
}
