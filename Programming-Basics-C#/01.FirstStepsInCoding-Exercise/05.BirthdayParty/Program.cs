using System;

namespace _05.BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double naemZala = double.Parse(Console.ReadLine());

            double cenaTorta = naemZala * 0.20;
            double cenaNapitki = cenaTorta -(0.45 * cenaTorta);
            double cenaAnimator = naemZala / 3;

            double cenaObshto = naemZala + cenaTorta + cenaNapitki + cenaAnimator;

            Console.WriteLine(cenaObshto);
        }
    }
}
