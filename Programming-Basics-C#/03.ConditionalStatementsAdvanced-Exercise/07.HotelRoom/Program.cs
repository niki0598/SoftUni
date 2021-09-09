using System;

namespace _07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string months = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());
            double studioMoney = 0;
            double apartmentMoney = 0;
            double totalMoneyStudio = 0;
            double totalMoneyApartment = 0;

            switch (months)
            {
                case "May":
                case "October":
                    studioMoney = 50 * nights;
                    apartmentMoney = 65 * nights;

                    if (nights <= 7)
                    {
                        totalMoneyStudio = studioMoney;
                        totalMoneyApartment = apartmentMoney;
                    }

                    else if (nights > 7 && nights <= 14)
                    {
                        totalMoneyStudio = studioMoney - studioMoney * 0.05;
                        totalMoneyApartment = apartmentMoney;
                    }
                    else if (nights > 14)
                    {
                        totalMoneyStudio = studioMoney - studioMoney * 0.3;
                        totalMoneyApartment = apartmentMoney - apartmentMoney * 0.1;
                    }
                    break;
                case "June":
                case "September":
                    studioMoney = 75.2 * nights;
                    apartmentMoney = 68.7 * nights;

                    if (nights > 14)
                    {
                        totalMoneyStudio = studioMoney - studioMoney * 0.2;
                        totalMoneyApartment = apartmentMoney - apartmentMoney * 0.1;
                    }
                    else
                    {
                        totalMoneyStudio = studioMoney;
                        totalMoneyApartment = apartmentMoney;
                    }
                    break;
                case "July":
                case "August":
                    studioMoney = 76 * nights;
                    apartmentMoney = 77 * nights;

                    if (nights > 14)
                    {
                        totalMoneyStudio = studioMoney;
                        totalMoneyApartment = apartmentMoney - apartmentMoney * 0.1;
                    }
                    else
                    {
                        totalMoneyStudio = studioMoney;
                        totalMoneyApartment = apartmentMoney;
                    }
                    break;
            }

            Console.WriteLine($"Apartment: {totalMoneyApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalMoneyStudio:f2} lv.");
        }
    }
}
