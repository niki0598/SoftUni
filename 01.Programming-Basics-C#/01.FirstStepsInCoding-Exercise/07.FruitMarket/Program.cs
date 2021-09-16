using System;

namespace _07.FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double cenaQgodi = double.Parse(Console.ReadLine());
            double kolichestvoBanani = double.Parse(Console.ReadLine());
            double kolichestvoPortokali = double.Parse(Console.ReadLine());
            double kolichestvoMalini = double.Parse(Console.ReadLine());
            double kolichestvoQgodi = double.Parse(Console.ReadLine());

            double cenaMalini = cenaQgodi / 2;
            double cenaPortokali = cenaMalini - (cenaMalini * 0.40);
            double cenaBanani = cenaMalini - (cenaMalini * 0.80);

            double sumMalini = kolichestvoMalini * cenaMalini;
            double sumPortokali = kolichestvoPortokali * cenaPortokali;
            double sumBanani = kolichestvoBanani * cenaBanani;
            double sumQgodi = kolichestvoQgodi * cenaQgodi;

            double krainaCena = sumMalini + sumPortokali + sumBanani + sumQgodi;

            Console.WriteLine($"{krainaCena:f2}");
        }
    }
}
