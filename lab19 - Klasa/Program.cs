﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab19___Klasa
{
    class Program
    {
        static void Main(string[] args)
        {
            Klasa klasa = new Klasa();
            Console.WriteLine(klasa.zmienna);
            klasa.zmienna = 10;
            Console.WriteLine(klasa.zmienna);

            Samochod samochod1 = new Samochod();
            Samochod samochod2 = new Samochod();

            samochod1.nazwa = "BMW";
            samochod1.rokProdukcji = 2000;
            samochod1.maksymalnaPredkosc = 220;
            samochod1.aktualnaPredkosc = 0;

            Console.WriteLine($"{samochod1.nazwa}{samochod1.rokProdukcji}{samochod1.aktualnaPredkosc}{samochod1.aktualnaPredkosc}");

            Console.ReadKey();

        }
    }
}
