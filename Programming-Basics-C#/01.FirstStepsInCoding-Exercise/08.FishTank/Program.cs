using System;

namespace _08.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int duljina = int.Parse(Console.ReadLine());
            int shirochina = int.Parse(Console.ReadLine());
            int visochina = int.Parse(Console.ReadLine());
            double procentZaeti = double.Parse(Console.ReadLine());

            double obemAkvarium = duljina * shirochina * visochina;
            double litriKoitoSubira = obemAkvarium * 0.001;
            procentZaeti *= 0.01;
            double svobodniLitri = litriKoitoSubira * (1 - procentZaeti);

            Console.WriteLine(svobodniLitri);
        }
    }
}
