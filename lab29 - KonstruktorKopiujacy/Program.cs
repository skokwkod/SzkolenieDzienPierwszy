using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab29___KonstruktorKopiujacy
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod1 = new Samochod("BMW", 5);

            Console.WriteLine($"Marka: {samochod1.Marka} Ilosc drzwi {samochod1.Drzwi} ");

            Samochod samochod2 = samochod1;

            Console.WriteLine($"Marka: {samochod2.Marka} Ilosc drzwi {samochod2.Drzwi} ");

            samochod2.Drzwi = 3;

            Samochod samochod3 = new Samochod(samochod1);

            Console.WriteLine($"Marka: {samochod1.Marka} Ilosc drzwi {samochod1.Drzwi} ");
            Console.WriteLine($"Marka: {samochod2.Marka} Ilosc drzwi {samochod2.Drzwi} ");
            Console.WriteLine($"Marka: {samochod3.Marka} Ilosc drzwi {samochod3.Drzwi} ");
            Console.WriteLine("====================================");
            samochod3.Drzwi = 6;
            Console.WriteLine($"Marka: {samochod1.Marka} Ilosc drzwi {samochod1.Drzwi} ");
            Console.WriteLine($"Marka: {samochod2.Marka} Ilosc drzwi {samochod2.Drzwi} ");
            Console.WriteLine($"Marka: {samochod3.Marka} Ilosc drzwi {samochod3.Drzwi} ");
            Console.WriteLine("====================================");
            Console.ReadKey();
        }
    }
}
