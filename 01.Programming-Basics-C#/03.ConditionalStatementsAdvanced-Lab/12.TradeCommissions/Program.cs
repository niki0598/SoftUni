using System;

namespace _12.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commission = 0;
            bool error = false;

            switch (city)
            {
                case "Sofia":
                    if (0 <= sales && sales <= 500)
                    {
                        commission = sales * 0.05;
                    }
                    else if (50 <= sales && sales <= 1000)
                    {
                        commission = sales * 0.07;
                    }
                    else if (1000 <= sales && sales <= 10000)
                    {
                        commission = sales * 0.08;
                    }
                    else if (sales > 10000)
                    {
                        commission = sales * 0.12;
                    }
                    else
                    {
                        error = true;
                    }
                    break;

                case "Varna":
                    if (0 <= sales && sales <= 500)
                    {
                        commission = sales * 0.045;
                    }
                    else if (50 <= sales && sales <= 1000)
                    {
                        commission = sales * 0.075;
                    }
                    else if (1000 <= sales && sales <= 10000)
                    {
                        commission = sales * 0.1;
                    }
                    else if (sales > 10000)
                    {
                        commission = sales * 0.13;
                    }
                    else
                    {
                        error = true;
                    }
                    break;

                case "Plovdiv":
                    if (0 <= sales && sales <= 500)
                    {
                        commission = sales * 0.055;
                    }
                    else if (50 <= sales && sales <= 1000)
                    {
                        commission = sales * 0.08;
                    }
                    else if (1000 <= sales && sales <= 10000)
                    {
                        commission = sales * 0.12;
                    }
                    else if (sales > 10000)
                    {
                        commission = sales * 0.145;
                    }
                    else
                    {
                        error = true;
                    }
                    break;

                default:
                    error = true;
                    break;
            }

            if (error == true)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{commission:f2}");
            }
        }
    }
}
