using System;

namespace _04.InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double centimeter = double.Parse(Console.ReadLine());
            double Inch = 2.54 * centimeter;

            Console.WriteLine(Inch);
        }
    }
}