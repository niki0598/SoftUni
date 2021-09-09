using System;

namespace _06.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = int.Parse(Console.ReadLine());
            double N2 = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            double result = 0;

            switch (symbol)
            {
                case '+':
                    result = N1 + N2;

                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{N1} {symbol} {N2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} {symbol} {N2} = {result} - odd");
                    }
                    break;
                case '-':
                    result = N1 - N2;

                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{N1} {symbol} {N2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} {symbol} {N2} = {result} - odd");
                    }
                    break;
                case '*':
                    result = N1 * N2;

                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{N1} {symbol} {N2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} {symbol} {N2} = {result} - odd");
                    }
                    break;
                case '/':

                    if (N2 != 0)
                    {
                        result = N1 / N2;
                        Console.WriteLine($"{N1} {symbol} {N2} = {result:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    break;
                case '%':

                    if (N2 != 0)
                    {
                        result = N1 % N2;
                        Console.WriteLine($"{N1} {symbol} {N2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    break;
            }
        }
    }
}
