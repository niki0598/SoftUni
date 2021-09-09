using System;

namespace _06.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            double area;

            if(shape == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;
                Console.WriteLine($"{area:f3}");
            }
            else if(shape == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                area = sideA * sideB;
                Console.WriteLine($"{area:f3}");
            }
            else if(shape == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = radius*radius * Math.PI;
                Console.WriteLine($"{area:f3}");
            }
            else if(shape == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = side/2 * height;
                Console.WriteLine($"{area:f3}");
            }
        }
    }
}
