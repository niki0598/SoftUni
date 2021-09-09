using System;

namespace _04.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inputValue = Console.ReadLine();
            string outputValue = Console.ReadLine();

            if (inputValue == "mm" && outputValue == "m")
            {
                number /= 1000;
            }
            else if (inputValue == "m" && outputValue == "mm")
            {
                number *= 1000;
            }
            else if (inputValue == "cm" && outputValue == "m")
            {
                number /= 100;
            }
            else if (inputValue == "m" && outputValue == "cm")
            {
                number *= 100;
            }
            else if (inputValue == "mm" && outputValue == "cm")
            {
                number /= 10;
            }
            else if (inputValue == "cm" && outputValue == "mm")
            {
                number *= 10;
            }

            Console.WriteLine($"{number:f3}");
        }
    }
}